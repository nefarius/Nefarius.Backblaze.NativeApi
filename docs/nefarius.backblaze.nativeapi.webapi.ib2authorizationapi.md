# IB2AuthorizationApi

Namespace: Nefarius.Backblaze.NativeApi.WebApi

Represents the authorization API for Backblaze B2.
 Provides methods to authorize an account with the Backblaze B2 service,
 enabling further interaction with the API.

```csharp
public interface IB2AuthorizationApi
```

## Methods

### <a id="methods-authorizeasync"/>**AuthorizeAsync(CancellationToken)**

Authorizes an account with the Backblaze B2 service, establishing the necessary
 credentials for further API interactions.

```csharp
Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)<br>
A cancellation token to cancel the asynchronous operation.

#### Returns

A task that represents the asynchronous operation. The task result contains the
 authorization response with details like account ID, authorization token, and service URLs.
