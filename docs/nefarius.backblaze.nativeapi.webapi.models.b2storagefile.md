# B2StorageFile

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents metadata about a stored file returned by Backblaze B2 listing operations.

```csharp
public sealed class B2StorageFile
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2StorageFile](./nefarius.backblaze.nativeapi.webapi.models.b2storagefile.md)

## Properties

### <a id="properties-accountid"/>**AccountId**

Gets or sets the unique identifier of the account that owns the file.

```csharp
public string AccountId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the identifier of the bucket containing the file.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-action"/>**Action**

Gets or sets the action that created this file version, such as "upload" or "delete".

```csharp
public string Action { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-contentlength"/>**ContentLength**

Gets or sets the size of the file in bytes.

```csharp
public long ContentLength { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### <a id="properties-contentmd5"/>**ContentMd5**

Gets or sets optional MD5 hash of the file contents.

```csharp
public string ContentMd5 { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-contentsha1"/>**ContentSha1**

Gets or sets the SHA1 hash of the file contents.

```csharp
public string ContentSha1 { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-contenttype"/>**ContentType**

Gets or sets the MIME type of the file.

```csharp
public string ContentType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-fileid"/>**FileId**

Gets or sets the unique identifier assigned to the file.

```csharp
public string FileId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-fileinfo"/>**FileInfo**

Gets or sets additional metadata associated with the file.

```csharp
public Dictionary<String, String> FileInfo { get; set; }
```

#### Property Value

[Dictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

### <a id="properties-filename"/>**FileName**

Gets or sets the name of the file within the bucket.

```csharp
public string FileName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-uploadtimestamp"/>**UploadTimestamp**

Gets or sets the upload timestamp in milliseconds since the epoch.

```csharp
public long UploadTimestamp { get; set; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2StorageFile()**

```csharp
public B2StorageFile()
```
