using LoginDemoMAUI.DAL;
using LoginDemoMAUI.ViewModels;
using LoginDemoMAUI.Views;
using Microsoft.Extensions.Logging;

namespace LoginDemoMAUI;

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
		builder.Services.AddSingleton<IDataAccess, MockDataAccess>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddTransient<FeedPage>();
		builder.Services.AddTransient<FeedViewModel>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
