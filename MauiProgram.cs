using Microsoft.Extensions.Logging;
using MauiDesktopApp.ViewModels;

namespace MauiDesktopApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<Views.LoginPage>();
		builder.Services.AddTransient<Views.ListRecipesPage>();
		builder.Services.AddSingleton<LoginViewModel>();
		builder.Services.AddTransient<ListRecipesViewModel>();
#if DEBUG
		builder.Logging.AddDebug();
#endif	

		return builder.Build();
	}
}
