using MauiMvvm.View;
using MauiMvvm.ViewModel;

namespace MauiMvvm;

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

		builder.Services.AddSingleton<EmployeeViewModel>();
		builder.Services.AddSingleton<CompanyViewModel>();

		builder.Services.AddSingleton<CompanyView>();
		builder.Services.AddSingleton<EmployeeView>();

		return builder.Build();
	}
}
