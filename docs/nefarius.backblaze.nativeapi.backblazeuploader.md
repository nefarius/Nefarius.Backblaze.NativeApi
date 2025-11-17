# BackblazeUploader

Namespace: Nefarius.Backblaze.NativeApi

```csharp
public class BackblazeUploader : IBackblazeUploader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BackblazeUploader](./nefarius.backblaze.nativeapi.backblazeuploader.md)<br>
Implements [IBackblazeUploader](./nefarius.backblaze.nativeapi.ibackblazeuploader.md)

## Constructors

### <a id="constructors-.ctor"/>**BackblazeUploader(IOptions&lt;BackblazeOptions&gt;, IHttpClientFactory)**

```csharp
public BackblazeUploader(IOptions<BackblazeOptions> options, IHttpClientFactory httpClientFactory)
```

#### Parameters

`options` IOptions&lt;BackblazeOptions&gt;<br>

`httpClientFactory` IHttpClientFactory<br>

## Methods

### <a id="methods-uploadasync"/>**UploadAsync(String, CancellationToken)**

```csharp
public Task UploadAsync(string filePath, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)

### <a id="methods-uploadasync"/>**UploadAsync(String, String, CancellationToken)**

```csharp
public Task UploadAsync(string filePath, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)

### <a id="methods-uploadasync"/>**UploadAsync(Stream, String, CancellationToken)**

```csharp
public Task UploadAsync(Stream content, string targetFileName, CancellationToken cancellationToken)
```

#### Parameters

`content` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`targetFileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>

#### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
