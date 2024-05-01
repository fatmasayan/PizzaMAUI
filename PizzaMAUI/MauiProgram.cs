using CommunityToolkit.Maui;
using PizzaMAUI.Pages;
namespace PizzaMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif
            AddPizzaServices(builder.Services);
            return builder.Build();
        }

        private static IServiceCollection AddPizzaServices(IServiceCollection services)
        {
            services.AddSingleton<PizzaService>();
            //services.AddSingleton<HomeViewModel>();
            services.AddSingletonWithShellRoute<HomePage, HomeViewModel>(nameof(HomePage));
            services.AddSingletonWithShellRoute<AllPizzaPage, AllPizzaViewModel>(nameof(AllPizzaPage));

            services.AddTransientWithShellRoute<DetailPage, DetailsViewModel>(nameof(DetailPage));
            return services;
        }
    }
}