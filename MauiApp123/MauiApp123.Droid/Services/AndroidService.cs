using MauiApp123.Services;

namespace MauiApp123.Android.Services;

public class AndroidService : IPlatformSpecificService
{
	public AndroidService()
	{
	}

	public string GetPlatformDescription()
	{
		return "Android";
	}
}
