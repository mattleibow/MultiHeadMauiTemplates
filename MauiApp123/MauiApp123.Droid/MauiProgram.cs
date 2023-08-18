using MauiApp123.Android.Services;
using MauiApp123.Services;

namespace MauiApp123;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseSharedMauiApp();

        builder.Services.AddTransient<IPlatformSpecificService, AndroidService>();

        return builder.Build();
    }
}
