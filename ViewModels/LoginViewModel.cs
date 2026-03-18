using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiDesktopApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private const string RequiredUsername = "admin";
    private const string RequiredPassword = "password";

    [ObservableProperty]
    public partial string Username { get; set; }

    [ObservableProperty]
    public partial string Password { get; set; }

    [ObservableProperty]
    public partial bool IsLoggedIn { get; set; }

    [ObservableProperty]
    public partial string LoginMessage { get; set; }

    public LoginViewModel()
    {
        Username = string.Empty;
        Password = string.Empty;
        LoginMessage = string.Empty;
        LoginCommand = new AsyncRelayCommand(ValidateLoginAsync);
    }

    public IAsyncRelayCommand LoginCommand { get; }

    private async Task ValidateLoginAsync()
    {
        var enteredUsername = Username?.Trim() ?? string.Empty;
        var enteredPassword = Password ?? string.Empty;

        IsLoggedIn = string.Equals(enteredUsername, RequiredUsername, StringComparison.Ordinal)
            && string.Equals(enteredPassword, RequiredPassword, StringComparison.Ordinal);

        if (IsLoggedIn)
        {
            LoginMessage = "You are now logged in!";
            await Shell.Current.GoToAsync(nameof(Views.ListRecipesPage));
            return;
        }

        LoginMessage = "Invalid username or password.";
    }
}