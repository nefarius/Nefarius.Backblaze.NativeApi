# B2ListFileVersionsRequest

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents a request to list different versions of files within a Backblaze B2 bucket.

```csharp
public sealed class B2ListFileVersionsRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2ListFileVersionsRequest](./nefarius.backblaze.nativeapi.webapi.models.b2listfileversionsrequest.md)

## Properties

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the unique identifier of the bucket to list file versions from.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-maxfilecount"/>**MaxFileCount**

Gets or sets the maximum number of file versions to return.

```csharp
public Nullable<Int32> MaxFileCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-startfileid"/>**StartFileId**

Gets or sets the file identifier to start listing from, used together with [B2ListFileVersionsRequest.StartFileName](./nefarius.backblaze.nativeapi.webapi.models.b2listfileversionsrequest.md#startfilename)
 for pagination.

```csharp
public string StartFileId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-startfilename"/>**StartFileName**

Gets or sets the file name to start listing from. If null, listing starts from the first
 file in the bucket.

```csharp
public string StartFileName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2ListFileVersionsRequest()**

```csharp
public B2ListFileVersionsRequest()
```
