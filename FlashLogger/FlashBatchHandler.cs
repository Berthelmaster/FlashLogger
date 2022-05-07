namespace FlashLogger
{
    public class FlashBatchHandler : IBatchHandler
    {
        private readonly FlashLoggerSettings settings;

        private int maxBatchSize = 100;

        public FlashBatchHandler(IDatabaseRepository databaseRepository, FlashLoggerSettings settings)
        {
            this.settings = settings;

            MaxBatchSize = settings.MaxBatchSize;
        }
        public int MaxBatchSize 
        { 
            get
            {
                return maxBatchSize;
            }
            set
            {
                maxBatchSize = value;
            }
        }

        public void AddOrPushBatch(string message, LogLevel logLevel, params object[] arguments)
        {
            throw new System.NotImplementedException();
        }

        public void ForcePush()
        {
            throw new System.NotImplementedException();
        }
    }
}
