# B2ListFileNamesRequest

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents a request to retrieve file names from a specific Backblaze B2 bucket.

```csharp
public sealed class B2ListFileNamesRequest
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2ListFileNamesRequest](./nefarius.backblaze.nativeapi.webapi.models.b2listfilenamesrequest.md)

## Properties

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the unique identifier of the bucket to list files from.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-maxfilecount"/>**MaxFileCount**

Gets or sets the maximum number of file names to return. Defaults to the
 service value when not specified.

```csharp
public Nullable<Int32> MaxFileCount { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-startfilename"/>**StartFileName**

Gets or sets the name of the first file to return. If null, the listing starts
 from the first file in the bucket.

```csharp
public string StartFileName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2ListFileNamesRequest()**

```csharp
public B2ListFileNamesRequest()
```
