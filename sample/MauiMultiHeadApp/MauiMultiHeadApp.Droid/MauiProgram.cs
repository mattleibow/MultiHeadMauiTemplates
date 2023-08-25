using MauiMultiHeadApp.Android.Services;
using MauiMultiHeadApp.Services;

namespace MauiMultiHeadApp;

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
