using System.Threading.Tasks;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Interfaces.Repositories;

namespace ASPLesson.DAL.Repositories
{
    public class LogRepository : ILogRepository
    {
        public async Task Create(Log log)
        {
            using (var db = new ApplicationDbContext())
            {
                await db.Logs.AddAsync(log);
                await db.SaveChangesAsync();
            }
        }
    }
}