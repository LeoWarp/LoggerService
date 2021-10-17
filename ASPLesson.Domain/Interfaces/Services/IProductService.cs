using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity.Reponse;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<BaseResponse> GetAllProducts();

        Task<BaseResponse> CreateProduct(CreateProductViewModel model);
    }
}