using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity.Reponse;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<BaseResponse> AddUser(CreateUserViewModel userModel);

        Task<BaseResponse> GetUser(int id);

        Task<BaseResponse> GetAllUsers();
    }
}