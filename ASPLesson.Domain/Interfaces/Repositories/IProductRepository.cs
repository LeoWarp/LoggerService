using System.Collections.Generic;
using System.Threading.Tasks;
using ASPLesson.Domain.Entity;

namespace ASPLesson.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        
        Task<Product> GetProduct(string name);
        
        Task<Product> Insert(Product product);
    }
}