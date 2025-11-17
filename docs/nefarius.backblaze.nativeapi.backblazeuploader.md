# BackblazeUploader

Namespace: Nefarius.Backblaze.NativeApi

Provides functionality for uploading files or streams to Backblaze B2 cloud storage.
 Implements the [IBackblazeUploader](./nefarius.backblaze.nativeapi.ibackblazeuploader.md) interface.

```csharp
public class BackblazeUploader : IBackblazeUploader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BackblazeUploader](./nefarius.backblaze.nativeapi.backblazeuploader.md)<br>
Implements [IBackblazeUploader](./nefarius.backblaze.nativeapi.ibackblazeuploader.md)

## Constructors

### <a id="constructors-.ctor"/>**BackblazeUploader(IOptions&lt;BackblazeOptions&gt;, IHttpClientFactory)**

Represents a class that facilitates the upload of files or streams to Backblaze B2 cloud storage.

```csharp
public BackblazeUploader(IOptions<BackblazeOptions> options, IHttpClientFactory httpClientFactory)
```

#### Parameters

`options` IOptions&lt;BackblazeOptions&gt;<br>

`httpClientFactory` IHttpClientFactory<br>

**Remarks:**

This class depends on  for HTTP communication and requires
 Backblaze configuration settings through [BackblazeOptions](./nefarius.backblaze.nativeapi.backblazeoptions.md).

## Methods

### <a id="methods-uploadasync"/>**UploadAsync(String, CancellationToken)**

Uploads a file to Backblaze B2 cloud storage using the specified file path.

```csharp
public Task UploadAsync(string filePath, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full path of the file to upload.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token that can be used to cancel the operation.

#### Returns

A task that represents the asynchronous upload operation.

#### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
Thrown when `filePath` is null, empty, or consists only of
 whitespace.

[FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception)<br>
Thrown when the file specified by `filePath` does not exist.

### <a id="methods-uploadasync"/>**UploadAsync(String, String, CancellationToken)**

Uploads a file to Backblaze B2 cloud storage.

```csharp
public Task UploadAsync(string filePath, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The full path of the file to upload.

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name of the file as it will appear in the target storage location.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) to observe while waiting for the task to complete.

#### Returns

A [Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task) that represents the asynchronous operation.

#### Exceptions

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
Thrown if `filePath` or `targetFileName` is
 null or whitespace.

[FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/system.io.filenotfoundexception)<br>
Thrown if the specified file does not exist at `filePath`.

### <a id="methods-uploadasync"/>**UploadAsync(Stream, String, CancellationToken)**

Uploads a stream of content to Backblaze B2 cloud storage with a specified target file name.

```csharp
public Task UploadAsync(Stream content, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`content` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The content stream to upload.

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name of the target file in the storage.

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
The token to monitor for cancellation requests.

#### Returns

A task that represents the asynchronous upload operation.

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
Thrown when `content` is null.

[ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception)<br>
Thrown when `targetFileName` is null or whitespace.
