using MauiApp123.Services;

namespace MauiApp123.Pages;

public partial class SecondPage : ContentPage
{
	readonly IPlatformSpecificService service;

	int count = 0;

	public SecondPage(IPlatformSpecificService service)
	{
		this.service = service;

		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time on {service.GetPlatformDescription()}";
		else
			CounterBtn.Text = $"Clicked {count} times on {service.GetPlatformDescription()}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
