using MauiApp123.Services;

namespace MauiApp123.Mac.Services;

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
