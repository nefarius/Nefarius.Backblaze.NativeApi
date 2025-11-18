# B2GetUploadUrlRequest

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents a request to retrieve an upload URL for a specified bucket in the Backblaze B2 Cloud Storage service.

```csharp
public sealed class B2GetUploadUrlRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2GetUploadUrlRequest](./nefarius.backblaze.nativeapi.webapi.models.b2getuploadurlrequest.md)

## Properties

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the unique identifier of the bucket for which the upload URL is being requested.
 This property is used to specify the target bucket in operations involving the Backblaze B2 Cloud Storage service.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2GetUploadUrlRequest()**

```csharp
public B2GetUploadUrlRequest()
```
