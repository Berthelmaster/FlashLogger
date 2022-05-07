using System.Threading.Tasks;

namespace FlashLogger
{
    public interface IDatabaseRepository
    {
        Task Add(string logMessage, params object[] arguments);
        Task<IEntity> Get(IEntity type, long rangeFrom = 0, long rangeTo = 100);
    }
}
