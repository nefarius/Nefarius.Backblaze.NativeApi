// See https://aka.ms/new-console-template for more information

using DemoApp;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Nefarius.Backblaze.NativeApi;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddBackblazeUploader(options =>
{
    options.KeyId = builder.Configuration["Backblaze:KeyId"];
    options.ApplicationKey = builder.Configuration["Backblaze:ApplicationKey"];
    options.BucketId = builder.Configuration["Backblaze:BucketId"];
});

builder.Services.AddHostedService<DemoHost>();

IHost host = builder.Build();

await host.RunAsync();