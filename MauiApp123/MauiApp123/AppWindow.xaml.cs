namespace MauiApp123;

public partial class AppWindow : Window
{
	public AppWindow(AppShell shell)
	{
		InitializeComponent();

		Page = shell;
	}
}
