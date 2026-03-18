using MauiDesktopApp.Views;

namespace MauiDesktopApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("ListRecipesPage", typeof(ListRecipesPage));
		Routing.RegisterRoute("AddRecipePage", typeof(AddRecipePage));
	}
}
