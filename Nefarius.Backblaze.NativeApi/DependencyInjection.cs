using Microsoft.Extensions.DependencyInjection;

namespace Nefarius.Backblaze.NativeApi;

public static class DependencyInjection
{
    public static IServiceCollection AddBackblazeUploader(
        this IServiceCollection services,
        Action<BackblazeOptions> configureOptions)
    {
        if (configureOptions is null)
        {
            throw new ArgumentNullException(nameof(configureOptions));
        }

        services.Configure(configureOptions);

        // Fixed auth endpoint
        services.AddHttpClient(BackblazeHttpClientNames.Authorization,
            client => { client.BaseAddress = new Uri("https://api.backblazeb2.com"); });

        // API client (base address set dynamically after authorization)
        services.AddHttpClient(BackblazeHttpClientNames.Api);

        // Upload client (base address set to uploadUrl per upload)
        services.AddHttpClient(BackblazeHttpClientNames.Upload);

        services.AddSingleton<IBackblazeUploader, BackblazeUploader>();

        return services;
    }
}