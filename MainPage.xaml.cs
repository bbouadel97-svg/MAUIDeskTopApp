using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
namespace MauiDesktopApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	
	}
	private async void LaunchPopup(object sender, EventArgs e)
	{
	  await DisplayAlertAsync("Popup", "Bonjour ! Ceci est une popup.", "OK");
	}
	
	private void QuitApp(object sender, EventArgs e)
	{
		Application.Current?.Quit();
	}
}
