using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiMultiHeadApp.WinUI;

public partial class App : MauiWinUIApplication
{
	public App()
	{
		InitializeComponent();
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
