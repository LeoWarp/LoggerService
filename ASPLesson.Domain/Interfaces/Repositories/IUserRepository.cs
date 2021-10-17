using System.Collections.Generic;
using System.Threading.Tasks;
using ASPLesson.Domain.Entity;

namespace ASPLesson.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> Insert(User user);
        Task<User> Get(int id);
        Task<User> GetByName(string name);
        Task<IEnumerable<User>> Select();
    }
}