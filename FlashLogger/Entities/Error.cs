using System;

namespace FlashLogger.Entities
{
    public class Error : IEntity
    {
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public DateTime LifeTime { get; set; }
    }
}
