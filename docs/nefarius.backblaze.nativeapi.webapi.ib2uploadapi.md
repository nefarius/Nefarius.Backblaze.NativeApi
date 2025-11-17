# IB2UploadApi

Namespace: Nefarius.Backblaze.NativeApi.WebApi

```csharp
public interface IB2UploadApi
```

## Methods

### <a id="methods-uploadasync"/>**UploadAsync(String, String, String, String, String, Stream, CancellationToken)**

```csharp
Task<ApiResponse<String>> UploadAsync(string uploadAuthToken, string fileName, string contentType, string sha1, string contentDisposition, Stream content, CancellationToken cancellationToken)
```

#### Parameters

`uploadAuthToken` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`contentType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`sha1` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`contentDisposition` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`content` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task&lt;ApiResponse&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)
