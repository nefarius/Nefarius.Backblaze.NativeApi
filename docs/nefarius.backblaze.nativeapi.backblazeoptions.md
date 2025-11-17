# BackblazeOptions

Namespace: Nefarius.Backblaze.NativeApi

Represents configuration options for interacting with Backblaze B2 cloud storage.

```csharp
public class BackblazeOptions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BackblazeOptions](./nefarius.backblaze.nativeapi.backblazeoptions.md)

**Remarks:**

The [BackblazeOptions](./nefarius.backblaze.nativeapi.backblazeoptions.md) class stores credentials and settings used to authenticate
 and interact with Backblaze B2 cloud storage. These settings include the key ID, application key,
 and the bucket ID for a specific B2 bucket. This class is typically configured through
 dependency injection and used by services requiring Backblaze authentication and interaction.

## Fields

### <a id="fields-sectionname"/>**SectionName**

```csharp
public static string SectionName;
```

## Properties

### <a id="properties-applicationkey"/>**ApplicationKey**

Gets or sets the Application Key used for authenticating with Backblaze B2 cloud storage.

```csharp
public string ApplicationKey { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

The Application Key, in conjunction with the Key ID, serves as a credential for secure communication
 with the Backblaze B2 API. It allows the client to perform tasks such as uploading files,
 downloading files, and managing buckets. Ensure this property is assigned a valid application key
 obtained from the Backblaze B2 account dashboard or configuration settings.

### <a id="properties-bucketid"/>**BucketId**

Gets or sets the Bucket ID associated with a specific bucket in Backblaze B2 cloud storage.

```csharp
public string BucketId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

The Bucket ID uniquely identifies a storage bucket within the Backblaze B2 account. It is required
 to perform various bucket-level operations, such as uploading files, retrieving bucket information,
 and obtaining upload URLs. This property must be configured with a valid Bucket ID retrieved from the
 Backblaze B2 account management interface.

### <a id="properties-keyid"/>**KeyId**

Gets or sets the Key ID used for authenticating with Backblaze B2 cloud storage.

```csharp
public string KeyId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

The Key ID is a credential required to authorize requests to the Backblaze B2 API.
 It works in combination with the Application Key to perform secure operations,
 such as uploading files, downloading files, and managing buckets.
 This property should be supplied with a valid value obtained from the Backblaze B2 account dashboard.

## Constructors

### <a id="constructors-.ctor"/>**BackblazeOptions()**

```csharp
public BackblazeOptions()
```
