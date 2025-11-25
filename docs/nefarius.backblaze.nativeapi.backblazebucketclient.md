# BackblazeBucketClient

Namespace: Nefarius.Backblaze.NativeApi

Provides convenience access to bucket APIs such as listing file names.

```csharp
public sealed class BackblazeBucketClient : IBackblazeBucketClient
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BackblazeBucketClient](./nefarius.backblaze.nativeapi.backblazebucketclient.md)<br>
Implements [IBackblazeBucketClient](./nefarius.backblaze.nativeapi.ibackblazebucketclient.md)

## Constructors

### <a id="constructors-.ctor"/>**BackblazeBucketClient(IOptions&lt;BackblazeOptions&gt;, IHttpClientFactory)**

Initializes a new instance of the [BackblazeBucketClient](./nefarius.backblaze.nativeapi.backblazebucketclient.md) class.

```csharp
public BackblazeBucketClient(IOptions<BackblazeOptions> options, IHttpClientFactory httpClientFactory)
```

#### Parameters

`options` IOptions&lt;BackblazeOptions&gt;<br>
Configuration options for Backblaze B2.

`httpClientFactory` IHttpClientFactory<br>
Factory used to create HTTP clients.

## Methods

### <a id="methods-listfilenamesasync"/>**ListFileNamesAsync(String, Nullable&lt;Int32&gt;, CancellationToken)**

```csharp
public Task<B2ListFileNamesResponse> ListFileNamesAsync(string startFileName, Nullable<Int32> maxFileCount, CancellationToken cancellationToken)
```

#### Parameters

`startFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`maxFileCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task&lt;B2ListFileNamesResponse&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)
