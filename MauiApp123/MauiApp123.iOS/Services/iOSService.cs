using MauiApp123.Services;

namespace MauiApp123.iOS.Services;

public class iOSService : IPlatformSpecificService
{
	public iOSService()
	{
	}

	public string GetPlatformDescription()
	{
		return "iOS";
	}
}
