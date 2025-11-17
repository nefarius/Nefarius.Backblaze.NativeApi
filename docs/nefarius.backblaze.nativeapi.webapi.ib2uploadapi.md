# IB2UploadApi

Namespace: Nefarius.Backblaze.NativeApi.WebApi

Defines methods for uploading files to the Backblaze B2 Cloud Storage service.

```csharp
public interface IB2UploadApi
```

## Methods

### <a id="methods-uploadasync"/>**UploadAsync(String, String, String, String, String, Stream, CancellationToken)**

Uploads a file to the Backblaze B2 Cloud Storage service.

```csharp
Task<ApiResponse<String>> UploadAsync(string uploadAuthToken, string fileName, string contentType, string sha1, string contentDisposition, Stream content, CancellationToken cancellationToken)
```

#### Parameters

`uploadAuthToken` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The authorization token obtained for the upload URL.

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name of the file being uploaded, URL-encoded.

`contentType` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The content type of the file, specified as a MIME type.

`sha1` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The SHA1 checksum of the file content for data integrity validation.

`contentDisposition` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Specifies how the content should be displayed, including filename handling.

`content` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The file content stream to be uploaded.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token for managing the upload operation.

#### Returns

A task representing the asynchronous operation, containing the server response as a string on success.
