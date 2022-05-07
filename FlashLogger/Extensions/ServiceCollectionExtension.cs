using Microsoft.Extensions.DependencyInjection;

namespace FlashLogger
{
    public static class ServiceCollectionExtension
    {

        internal static void AddFlashLoggerSettings(this IServiceCollection serviceCollection, FlashLoggerSettings settings)
        {
            serviceCollection.AddSingleton(settings);
        }
    }
}
