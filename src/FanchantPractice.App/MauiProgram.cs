using Microsoft.Extensions.Logging;

using FanchantPractice.App.Data;
using FanchantPractice.App.Services;
using FanchantPractice.App.Services.Interfaces;
using FanchantPractice.App.ViewModels;
using FanchantPractice.App.Views;

namespace FanchantPractice.App;

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

		builder.Services.AddSingleton<AppDatabase>();
		builder.Services.AddSingleton<IDatabaseInitializer, DatabaseInitializer>();
		builder.Services.AddSingleton<IFanchantSyncService, FanchantSyncService>();
		builder.Services.AddSingleton<HomeViewModel>();
		builder.Services.AddSingleton<HomePage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
