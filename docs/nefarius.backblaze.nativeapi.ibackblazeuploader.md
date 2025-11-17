# IBackblazeUploader

Namespace: Nefarius.Backblaze.NativeApi

```csharp
public interface IBackblazeUploader
```

## Methods

### <a id="methods-uploadasync"/>**UploadAsync(String, CancellationToken)**

Uploads a local file to Backblaze B2.

```csharp
Task UploadAsync(string filePath, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)

### <a id="methods-uploadasync"/>**UploadAsync(String, String, CancellationToken)**

Uploads a local file to Backblaze B2, assigning a custom target name.

```csharp
Task UploadAsync(string filePath, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)

### <a id="methods-uploadasync"/>**UploadAsync(Stream, String, CancellationToken)**

Uploads a stream to Backblaze B2 using the given target file name.

```csharp
Task UploadAsync(Stream content, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`content` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
