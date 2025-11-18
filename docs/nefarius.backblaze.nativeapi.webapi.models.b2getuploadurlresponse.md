# B2GetUploadUrlResponse

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents the response from the Backblaze B2 API when requesting an upload URL for a specific bucket.

```csharp
public sealed class B2GetUploadUrlResponse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2GetUploadUrlResponse](./nefarius.backblaze.nativeapi.webapi.models.b2getuploadurlresponse.md)

**Remarks:**

The response includes the bucket ID, an upload URL, and an authorization token.
 These values are required to directly upload files to the designated bucket.

## Properties

### <a id="properties-authorizationtoken"/>**AuthorizationToken**

Gets or sets the authorization token required to authenticate file uploads to the designated bucket.

```csharp
public string AuthorizationToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

This property represents the token returned by the Backblaze B2 API when requesting an upload URL.
 The token is used to authorize file uploads and must be included in the "Authorization" header of uploading
 requests.

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the unique identifier of the bucket associated with the upload URL.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

This property identifies the specific bucket to which files will be uploaded.
 It is part of the response returned by the Backblaze B2 API when an upload URL is requested.

### <a id="properties-uploadurl"/>**UploadUrl**

Gets or sets the URL to which files will be directly uploaded in the designated bucket.

```csharp
public string UploadUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

The value of this property is provided in the response from the Backblaze B2 API when requesting an upload URL.
 The URL is specific to a given bucket and is used in conjunction with an authorization token for performing
 uploads.

## Constructors

### <a id="constructors-.ctor"/>**B2GetUploadUrlResponse()**

```csharp
public B2GetUploadUrlResponse()
```
