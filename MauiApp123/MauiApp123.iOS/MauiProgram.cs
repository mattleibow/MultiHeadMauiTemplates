using MauiApp123.iOS.Services;
using MauiApp123.Services;

namespace MauiApp123;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseSharedMauiApp();

		builder.Services.AddTransient<IPlatformSpecificService, iOSService>();

		return builder.Build();
	}
}
