using MauiDesktopApp.ViewModels;

namespace MauiDesktopApp.Views;

public partial class ListRecipesPage : ContentPage
{
    public ListRecipesPage(ListRecipesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
