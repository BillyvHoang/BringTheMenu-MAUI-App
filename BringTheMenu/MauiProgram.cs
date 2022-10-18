using BringTheMenu.MVVM.View;
using BringTheMenu.MVVM.View.Tabs;
using BringTheMenu.MVVM.ViewModel.Tabs;

namespace BringTheMenu;

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

		builder.Services.AddSingleton<Account>();
        builder.Services.AddSingleton<Account_ViewModel>();


        builder.Services.AddSingleton<BrowseMenu>();
        builder.Services.AddSingleton<BrowseMenu_ViewModel>();

        builder.Services.AddSingleton<Menu_Button>();
        builder.Services.AddSingleton<Menu_Button_ViewModel>();

        return builder.Build();
	}
}
