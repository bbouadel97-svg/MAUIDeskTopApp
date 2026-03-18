using MauiDesktopApp.ViewModels;
using Microsoft.Maui.Controls;


namespace MauiDesktopApp.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}

