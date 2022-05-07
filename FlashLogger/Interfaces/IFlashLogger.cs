using Microsoft.Extensions.Logging;

namespace FlashLogger
{
    internal interface IFlashLogger<T> where T : class
    {
        void LogInformation(string message, params object[] props);
        void LogError(string message, params object[] props);

    }
}
