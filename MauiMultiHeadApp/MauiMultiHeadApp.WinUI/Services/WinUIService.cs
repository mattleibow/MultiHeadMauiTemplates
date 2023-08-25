using MauiMultiHeadApp.Services;

namespace MauiMultiHeadApp.WinUI.Services;

public class WinUIService : IPlatformSpecificService
{
	public WinUIService()
	{
	}

	public string GetPlatformDescription()
	{
		return "WinUI";
	}
}
