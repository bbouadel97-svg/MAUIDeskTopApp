using MauiDesktopApp.Views;

namespace MauiDesktopApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListRecipesPage), typeof(ListRecipesPage));
	}
}
