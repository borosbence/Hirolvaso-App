using Hirolvaso.ViewModels;
using Hirolvaso.Views;

namespace Hirolvaso;

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

        builder.Services.AddSingleton<HatterkepViewModel>();
        builder.Services.AddSingleton<HatterkepPage>();
        builder.Services.AddSingleton<ArfolyamViewModel>();
        builder.Services.AddSingleton<ArfolyamPage>();
        builder.Services.AddSingleton<IdojarasViewModel>();
        builder.Services.AddSingleton<IdojarasPage>();
        builder.Services.AddSingleton<HirekViewModel>();
        builder.Services.AddSingleton<HirekPage>();
        builder.Services.AddSingleton<NevnapViewModel>();
        builder.Services.AddSingleton<NevnapPage>();

        return builder.Build();
    }
}
