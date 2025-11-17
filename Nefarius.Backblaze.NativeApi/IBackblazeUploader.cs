namespace Nefarius.Backblaze.NativeApi;

public interface IBackblazeUploader
{
    /// <summary>
    ///     Uploads a local file to the configured Backblaze B2 bucket.
    /// </summary>
    /// <param name="filePath">Full path to the file to upload.</param>
    /// <param name="cancellationToken"></param>
    Task UploadAsync(string filePath, CancellationToken cancellationToken = default);
}