using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Nefarius.Backblaze.NativeApi;
using Nefarius.Backblaze.NativeApi.WebApi.Models;

namespace DemoApp;

internal sealed class DemoHost(IBackblazeUploader uploader, IBackblazeBucketClient client, ILogger<DemoHost> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        B2ListFileNamesResponse files = await client.ListFileNamesAsync(cancellationToken: stoppingToken);

        foreach (B2StorageFile file in files.Files)
        {
            logger.LogInformation("Got remote file: {File}", file.FileName);
        }
        
        /*await uploader.UploadAsync(@"D:\Downloads\Everything-1.4.1.1028.x64-Setup.exe", "target/Everything.exe",
            stoppingToken);*/
    }
}