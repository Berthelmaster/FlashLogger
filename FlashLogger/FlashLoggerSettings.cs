namespace FlashLogger
{
    public class FlashLoggerSettings
    {
        public int MaxBatchSize { get; set; }
        public DatabaseOptions DatabaseOptions { get; set; }

        public FlashLoggerSettings(int maxBatchSize = 1000, DatabaseOptions databaseOptions = DatabaseOptions.MSSQL)
        {
            MaxBatchSize = maxBatchSize;
            DatabaseOptions = databaseOptions;
        }
    }

    public enum DatabaseOptions
    {
        MSSQL,
        REDIS
    }
}
