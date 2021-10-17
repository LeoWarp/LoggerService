using System.Collections.Generic;
using ASPLesson.Domain.Entity;
using System.Threading.Tasks;
using ASPLesson.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ASPLesson.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> Insert(User user)
        {
            using (var db  = new ApplicationDbContext())
            {
                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
                return user;
            }
        }

        public async Task<User> Get(int id)
        {
            using (var db  = new ApplicationDbContext())
            {
                return await db.Users.FirstOrDefaultAsync(x => x.Id == id);
            }
        }

        public async Task<User> GetByName(string name)
        {
            using (var db = new ApplicationDbContext())
            {
                return await db.Users.FirstOrDefaultAsync(x => x.Name == name);
            }
        }

        public async Task<IEnumerable<User>> Select()
        {
            using (var db  = new ApplicationDbContext())
            {
                return await db.Users.ToListAsync();
            }
        }
    }
}
