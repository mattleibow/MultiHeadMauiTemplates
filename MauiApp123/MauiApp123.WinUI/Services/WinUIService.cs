using MauiApp123.Services;

namespace MauiApp123.WinUI.Services;

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
