using Microsoft.Extensions.Logging;

namespace FlashLogger
{
    public class FlashLog<T> : IFlashLogger<T> where T : class
    {
        private readonly ILogger<T> logger;
        private readonly IBatchHandler batchHandler;

        public FlashLog(ILogger<T> logger, IBatchHandler batchHandler)
        {
            this.logger = logger;
            this.batchHandler = batchHandler;
        }

        public void LogError(string message, params object[] props)
        {
            logger.LogError(message, props);

            batchHandler.AddOrPushBatch(message, LogLevel.ERROR, props);
        }

        public void LogInformation(string message, params object[] props)
        {
            logger.LogInformation(message, props);

            batchHandler.AddOrPushBatch(message, LogLevel.INFORMATION, props);
        }
    }

    public enum LogLevel
    {
        ERROR,
        INFORMATION
    }
}
