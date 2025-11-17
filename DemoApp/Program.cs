// See https://aka.ms/new-console-template for more information

using DemoApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nefarius.Backblaze.NativeApi;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddBackblazeUploader(options =>
{
    options.KeyId = builder.Configuration["Backblaze:KeyId"];
    options.ApplicationKey = builder.Configuration["Backblaze:ApplicationKey"];
    options.BucketId = builder.Configuration["Backblaze:BucketId"];
});

builder.Services.AddHostedService<DemoHost>();

var host = builder.Build();

await host.RunAsync();