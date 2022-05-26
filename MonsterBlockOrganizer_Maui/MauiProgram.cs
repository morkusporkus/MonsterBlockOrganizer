using Microsoft.AspNetCore.Components.WebView.Maui;
using MonsterBlockOrganizer_Maui.Data;
using MudBlazor.Services;

namespace MonsterBlockOrganizer_Maui;

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
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddMudServices();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<MonsterBlockService>();

		return builder.Build();
	}
}
