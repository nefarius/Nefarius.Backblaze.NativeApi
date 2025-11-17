namespace Nefarius.Backblaze.NativeApi;

public interface IBackblazeUploader
{
    /// <summary>
    ///     Uploads a local file to Backblaze B2.
    /// </summary>
    Task UploadAsync(string filePath, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Uploads a local file to Backblaze B2, assigning a custom target name.
    /// </summary>
    Task UploadAsync(string filePath, string targetFileName, CancellationToken cancellationToken = default);

    /// <summary>
    ///     Uploads a stream to Backblaze B2 using the given target file name.
    /// </summary>
    Task UploadAsync(Stream content, string targetFileName, CancellationToken cancellationToken = default);
}