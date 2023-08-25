using MauiMultiHeadApp.Services;

namespace MauiMultiHeadApp.Mac.Services;

public class MacCatalystService : IPlatformSpecificService
{
	public MacCatalystService()
	{
	}

	public string GetPlatformDescription()
	{
		return "Mac Catalyst";
	}
}
