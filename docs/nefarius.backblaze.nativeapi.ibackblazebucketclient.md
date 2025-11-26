# IBackblazeBucketClient

Namespace: Nefarius.Backblaze.NativeApi

Provides access to Backblaze B2 bucket operations.

```csharp
public interface IBackblazeBucketClient
```

## Methods

### <a id="methods-listfilenamesasync"/>**ListFileNamesAsync(String, Nullable&lt;Int32&gt;, CancellationToken)**

Lists file names in the configured Backblaze bucket.

```csharp
Task<B2ListFileNamesResponse> ListFileNamesAsync(string startFileName, Nullable<Int32> maxFileCount, CancellationToken cancellationToken)
```

#### Parameters

`startFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Optional starting point for pagination.

`maxFileCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional maximum number of files to return.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
The token to monitor for cancellation requests.

#### Returns

The files and pagination marker returned by Backblaze.

### <a id="methods-listfileversionsasync"/>**ListFileVersionsAsync(String, String, Nullable&lt;Int32&gt;, CancellationToken)**

Lists different versions of files in the configured Backblaze bucket.

```csharp
Task<B2ListFileVersionsResponse> ListFileVersionsAsync(string startFileName, string startFileId, Nullable<Int32> maxFileCount, CancellationToken cancellationToken)
```

#### Parameters

`startFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Optional file name to start listing from.

`startFileId` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Optional file identifier to start listing from.

`maxFileCount` [Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional maximum number of file versions to return.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
The token to monitor for cancellation requests.

#### Returns

The file versions and pagination markers returned by Backblaze.
