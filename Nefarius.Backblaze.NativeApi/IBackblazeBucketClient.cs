namespace Nefarius.Backblaze.NativeApi;

using Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Provides access to Backblaze B2 bucket operations.
/// </summary>
public interface IBackblazeBucketClient
{
    /// <summary>
    ///     Lists file names in the configured Backblaze bucket.
    /// </summary>
    /// <param name="startFileName">Optional starting point for pagination.</param>
    /// <param name="maxFileCount">Optional maximum number of files to return.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>The files and pagination marker returned by Backblaze.</returns>
    Task<B2ListFileNamesResponse> ListFileNamesAsync(
        string? startFileName = null,
        int? maxFileCount = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    ///     Lists different versions of files in the configured Backblaze bucket.
    /// </summary>
    /// <param name="startFileName">Optional file name to start listing from.</param>
    /// <param name="startFileId">Optional file identifier to start listing from.</param>
    /// <param name="maxFileCount">Optional maximum number of file versions to return.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>The file versions and pagination markers returned by Backblaze.</returns>
    Task<B2ListFileVersionsResponse> ListFileVersionsAsync(
        string? startFileName = null,
        string? startFileId = null,
        int? maxFileCount = null,
        CancellationToken cancellationToken = default);
}
