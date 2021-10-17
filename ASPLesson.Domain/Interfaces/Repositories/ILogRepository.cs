using System.Threading.Tasks;
using ASPLesson.Domain.Entity;

namespace ASPLesson.Domain.Interfaces.Repositories
{
    public interface ILogRepository
    {
        Task Create(Log log);
    }
}