using Microsoft.Extensions.Logging;

namespace MauiAppHotelAtualizado
{
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
                    fonts.AddFont("DancingScript-Bold.ttf", "DancingScriptBold");
                    fonts.AddFont("DancingScript-Regular.ttf", "DancingScriptRegular");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}