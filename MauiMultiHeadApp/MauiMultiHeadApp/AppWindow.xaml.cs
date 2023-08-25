namespace MauiMultiHeadApp;

public partial class AppWindow : Window
{
	public AppWindow(AppShell shell)
	{
		InitializeComponent();

		Page = shell;
	}
}
