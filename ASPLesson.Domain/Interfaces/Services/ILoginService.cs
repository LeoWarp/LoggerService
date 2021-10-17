using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity.Reponse;

namespace ASPLesson.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<BaseResponse> Login(LoginViewModel loginModel);

        Task<BaseResponse> Register(RegisterViewModel registerModel);
    }
}