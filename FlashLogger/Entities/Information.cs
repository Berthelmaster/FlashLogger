using System;

namespace FlashLogger.Entities
{
    public class Information : IEntity
    {
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public DateTime LifeTime { get; set; }
    }
}
