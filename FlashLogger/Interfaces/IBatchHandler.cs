namespace FlashLogger
{
    public interface IBatchHandler
    {
        int MaxBatchSize { get; set; }

        void AddOrPushBatch(string message, LogLevel logLevel, params object[] arguments);
        void ForcePush();
    }
}
