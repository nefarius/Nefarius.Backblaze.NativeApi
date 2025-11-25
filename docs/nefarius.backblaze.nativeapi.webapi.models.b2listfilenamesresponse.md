# B2ListFileNamesResponse

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents the response returned when listing file names in a Backblaze B2 bucket.

```csharp
public sealed class B2ListFileNamesResponse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2ListFileNamesResponse](./nefarius.backblaze.nativeapi.webapi.models.b2listfilenamesresponse.md)

## Properties

### <a id="properties-files"/>**Files**

Gets or sets the collection of files returned by the listing operation.

```csharp
public IEnumerable<B2StorageFile> Files { get; set; }
```

#### Property Value

[IEnumerable&lt;B2StorageFile&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### <a id="properties-nextfilename"/>**NextFileName**

Gets or sets the name of the next file to start the listing from, or null when
 there are no additional files.

```csharp
public string NextFileName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2ListFileNamesResponse()**

```csharp
public B2ListFileNamesResponse()
```
