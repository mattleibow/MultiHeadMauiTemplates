using MauiApp123.WinUI.Services;
using MauiApp123.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

namespace MauiApp123;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseSharedMauiApp();

        builder.Services.AddTransient<IPlatformSpecificService, WinUIService>();

        return builder.Build();
    }
}
