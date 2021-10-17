using System.Collections.Generic;
using System.Threading.Tasks;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ASPLesson.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            using (var db = new ApplicationDbContext())
            {
                return await db.Products.ToListAsync();
            }
        }

        public async Task<Product> GetProduct(string name)
        {
            using (var db = new ApplicationDbContext())
            {
                return await db.Products.FirstOrDefaultAsync(x => x.Name == name);
            }
        }

        public async Task<Product> Insert(Product product)
        {
            using (var db = new ApplicationDbContext())
            {
                await db.Products.AddAsync(product);
                await db.SaveChangesAsync();
                return product;
            }
        }
    }
}