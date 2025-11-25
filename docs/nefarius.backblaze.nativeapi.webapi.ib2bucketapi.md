# IB2BucketApi

Namespace: Nefarius.Backblaze.NativeApi.WebApi

Defines methods for interacting with Backblaze B2 bucket-related API endpoints.

```csharp
public interface IB2BucketApi
```

## Methods

### <a id="methods-getuploadurlasync"/>**GetUploadUrlAsync(B2GetUploadUrlRequest, String, CancellationToken)**

Requests an upload URL for a specified bucket.

```csharp
Task<B2GetUploadUrlResponse> GetUploadUrlAsync(B2GetUploadUrlRequest request, string authToken, CancellationToken cancellationToken)
```

#### Parameters

`request` [B2GetUploadUrlRequest](./nefarius.backblaze.nativeapi.webapi.models.b2getuploadurlrequest.md)<br>
The request containing the bucket ID for which to fetch the upload URL.

`authToken` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The authorization token to authenticate the API call.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A token to monitor for cancellation requests.

#### Returns

A response containing an upload URL and authorization token for the specified bucket.

### <a id="methods-listfilenamesasync"/>**ListFileNamesAsync(B2ListFileNamesRequest, String, CancellationToken)**

Lists file names stored within the specified bucket.

```csharp
Task<B2ListFileNamesResponse> ListFileNamesAsync(B2ListFileNamesRequest request, string authToken, CancellationToken cancellationToken)
```

#### Parameters

`request` [B2ListFileNamesRequest](./nefarius.backblaze.nativeapi.webapi.models.b2listfilenamesrequest.md)<br>
The request containing the bucket identifier and optional pagination details.

`authToken` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The authorization token required to access the bucket.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A token to monitor for cancellation requests.

#### Returns

A response containing the file names and pagination marker.
