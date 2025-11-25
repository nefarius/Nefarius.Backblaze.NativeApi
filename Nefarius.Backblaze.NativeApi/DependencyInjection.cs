using Microsoft.Extensions.DependencyInjection;

namespace Nefarius.Backblaze.NativeApi;

/// <summary>
///     Provides extension methods for setting up dependencies related to Backblaze B2 cloud storage.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    ///     Registers services required for using Backblaze B2 cloud storage within the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection to add the Backblaze services to.</param>
    /// <param name="configureOptions">
    ///     An action to configure <see cref="BackblazeOptions" /> with necessary credentials and
    ///     settings.
    /// </param>
    /// <returns>The updated service collection with Backblaze services registered.</returns>
    public static IServiceCollection AddBackblazeUploader(
        this IServiceCollection services,
        Action<BackblazeOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(configureOptions);

        services.Configure(configureOptions);

        // Fixed auth endpoint
        services.AddHttpClient(BackblazeHttpClientNames.Authorization,
            client => { client.BaseAddress = new Uri("https://api.backblazeb2.com"); });

        // API client (base address set dynamically after authorization)
        services.AddHttpClient(BackblazeHttpClientNames.Api);

        // Upload client (base address set to uploadUrl per upload)
        services.AddHttpClient(BackblazeHttpClientNames.Upload);

        services.AddSingleton<IBackblazeUploader, BackblazeUploader>();
        services.AddSingleton<IBackblazeBucketClient, BackblazeBucketClient>();

        return services;
    }
}