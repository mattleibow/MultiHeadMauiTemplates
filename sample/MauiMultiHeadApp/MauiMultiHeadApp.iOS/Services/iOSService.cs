using MauiMultiHeadApp.Services;

namespace MauiMultiHeadApp.iOS.Services;

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
