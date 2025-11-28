# DependencyInjection

Namespace: Nefarius.Backblaze.NativeApi

Provides extension methods for setting up dependencies related to Backblaze B2 cloud storage.

```csharp
public static class DependencyInjection
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DependencyInjection](./nefarius.backblaze.nativeapi.dependencyinjection.md)

## Methods

### <a id="methods-addbackblazebucket"/>**AddBackblazeBucket(IServiceCollection, Action&lt;BackblazeOptions&gt;)**

Registers services required for using Backblaze B2 cloud storage within the dependency injection container.

```csharp
public static IServiceCollection AddBackblazeBucket(IServiceCollection services, Action<BackblazeOptions> configureOptions)
```

#### Parameters

`services` IServiceCollection<br>
The service collection to add the Backblaze services to.

`configureOptions` [Action&lt;BackblazeOptions&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
An action to configure [BackblazeOptions](./nefarius.backblaze.nativeapi.backblazeoptions.md) with necessary credentials and
 settings.

#### Returns

The updated service collection with Backblaze services registered.
