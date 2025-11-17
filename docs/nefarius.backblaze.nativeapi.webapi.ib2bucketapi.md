# IB2BucketApi

Namespace: Nefarius.Backblaze.NativeApi.WebApi

```csharp
public interface IB2BucketApi
```

## Methods

### <a id="methods-getuploadurlasync"/>**GetUploadUrlAsync(B2GetUploadUrlRequest, String, CancellationToken)**

```csharp
Task<B2GetUploadUrlResponse> GetUploadUrlAsync(B2GetUploadUrlRequest request, string authToken, CancellationToken cancellationToken)
```

#### Parameters

`request` [B2GetUploadUrlRequest](./nefarius.backblaze.nativeapi.webapi.models.b2getuploadurlrequest.md)<br>

`authToken` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task&lt;B2GetUploadUrlResponse&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)
