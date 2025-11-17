using Microsoft.Extensions.Hosting;

using Nefarius.Backblaze.NativeApi;

namespace DemoApp;

public class DemoHost(IBackblazeUploader uploader) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await uploader.UploadAsync(@"D:\Downloads\Everything-1.4.1.1028.x64-Setup.exe", "target/Everything.exe",
            stoppingToken);
    }
}