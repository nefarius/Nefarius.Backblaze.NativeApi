# B2AuthorizeAccountResponse

Namespace: Nefarius.Backblaze.NativeApi.WebApi.Models

Represents the response returned after successfully authorizing an account with the Backblaze B2 API.
 This response contains essential details required for accessing other API functionalities,
 such as the account ID, authorization token, and API endpoints.

```csharp
public sealed class B2AuthorizeAccountResponse
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [B2AuthorizeAccountResponse](./nefarius.backblaze.nativeapi.webapi.models.b2authorizeaccountresponse.md)

## Properties

### <a id="properties-accountid"/>**AccountId**

Gets or sets the unique identifier of the authorized Backblaze B2 account.
 This identifier is used to associate requests with a specific account
 after successful authorization.

```csharp
public string AccountId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-apiurl"/>**ApiUrl**

Gets or sets the base URL of the Backblaze B2 API for the authorized account.
 This URL serves as the endpoint for making API requests specific to the account
 after successful authorization.

```csharp
public string ApiUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-authorizationtoken"/>**AuthorizationToken**

Gets or sets the authorization token required for accessing authorized API endpoints
 in the Backblaze B2 system. This token is issued upon successful account authorization
 and must be included in the headers of subsequent API requests to validate access rights.

```csharp
public string AuthorizationToken { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-downloadurl"/>**DownloadUrl**

Gets or sets the URL for downloading files from the Backblaze B2 cloud storage.
 This URL serves as the endpoint for direct file access and retrieval operations.

```csharp
public string DownloadUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**B2AuthorizeAccountResponse()**

```csharp
public B2AuthorizeAccountResponse()
```
