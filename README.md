# <img src="assets/NSS-128x128.png" align="left" />Nefarius.Backblaze.NativeApi

[![.NET](https://github.com/nefarius/Nefarius.Backblaze.NativeApi/actions/workflows/build.yml/badge.svg)](https://github.com/nefarius/Nefarius.Backblaze.NativeApi/actions/workflows/build.yml)
![Requirements](https://img.shields.io/badge/Requires-.NET%209.0-blue.svg)
[![Nuget](https://img.shields.io/nuget/v/Nefarius.Backblaze.NativeApi)](https://www.nuget.org/packages/Nefarius.Backblaze.NativeApi/)
[![Nuget](https://img.shields.io/nuget/dt/Nefarius.Backblaze.NativeApi)](https://www.nuget.org/packages/Nefarius.Backblaze.NativeApi/)

Small wrapper for [Backblaze B2 Native API](https://www.backblaze.com/docs/cloud-storage-native-api) using [Refit](https://github.com/reactiveui/refit).

> [!IMPORTANT]
> This project is still evolving, so API-breaking changes might occur each update!

## About

A thin .NET wrapper around the Backblaze B2 Native API designed to fit into modern dependency injection setups.

### Current features

- Registration helper `AddBackblazeUploader` to wire up typed HTTP clients and configuration in DI containers.
- `IBackblazeUploader` for uploading files or streams with automatic SHA1 calculation and upload URL negotiation.
- `IBackblazeBucketClient` for listing file names and file versions in a bucket.
- Backed by strongly typed Refit clients for authorization, bucket, and upload endpoints.

## Usage examples

### Dependency injection registration

```csharp
using Microsoft.Extensions.DependencyInjection;
using Nefarius.Backblaze.NativeApi;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddBackblazeUploader(options =>
{
    options.KeyId = builder.Configuration["Backblaze:KeyId"];
    options.ApplicationKey = builder.Configuration["Backblaze:ApplicationKey"];
    options.BucketId = builder.Configuration["Backblaze:BucketId"];
});
```

### Upload a file

```csharp
using Nefarius.Backblaze.NativeApi;

public class UploaderService(IBackblazeUploader uploader)
{
    public async Task UploadAsync(CancellationToken cancellationToken)
    {
        await uploader.UploadAsync("/path/to/local/file.zip", "backups/file.zip", cancellationToken);
    }
}
```

### List files in a bucket

```csharp
using Nefarius.Backblaze.NativeApi;
using Nefarius.Backblaze.NativeApi.WebApi.Models;

public class ListingService(IBackblazeBucketClient client, ILogger<ListingService> logger)
{
    public async Task LogFileNamesAsync(CancellationToken cancellationToken)
    {
        B2ListFileNamesResponse files = await client.ListFileNamesAsync(cancellationToken: cancellationToken);

        foreach (B2StorageFile file in files.Files)
        {
            logger.LogInformation("Found remote file: {FileName}", file.FileName);
        }
    }
}
```

## Documentation

[Link to API docs](docs/index.md).

## 3rd party credits

- [Refit](https://github.com/reactiveui/refit)
