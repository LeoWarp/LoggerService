using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Entity.Reponse;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Repositories;
using ASPLesson.Domain.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace ASPLesson.Domain.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private ILogger<UserService> _logger;

        public UserService(IUserRepository userRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<BaseResponse> AddUser(CreateUserViewModel userModel)
        {
            var baseResponse = new BaseResponse();
            try
            {
                var user = await _userRepository.GetByName(userModel.Name);
                if (user == null)
                {
                    user = new User { Name = userModel.Name };
                    await _userRepository.Insert(user);
                    _logger.LogInformation($"{user.Name} added");
                    baseResponse.StatusCode = ErrorCode.OK;
                    baseResponse.Message = $"{user.Name} added";
                    baseResponse.Data = user;
                    return baseResponse;
                }
                _logger.LogInformation($"User - {userModel.Name} exists");
                baseResponse.StatusCode = ErrorCode.OK;
                baseResponse.Message = $"User - {userModel.Name} exists";
                return baseResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(500, $"Internal error, {ex.Message}");
                return new BaseResponse()
                {
                    StatusCode = ErrorCode.InternalError,
                    Message = $"Internal error, {ex.Message}"
                };
            }
        }

        public async Task<BaseResponse> GetUser(int id)
        {
            var baseResponse = new BaseResponse();
            try
            {
                var user = await _userRepository.Get(id);
                if (user != null)
                {
                    _logger.LogInformation($"User - {user.Name} exists");
                    baseResponse.StatusCode = ErrorCode.OK;
                    baseResponse.Message = $"User - {user.Name} exists";
                    baseResponse.Data = user;
                    return baseResponse;
                }
                _logger.LogInformation("User is not found");
                baseResponse.StatusCode = ErrorCode.OK;
                baseResponse.Message = "User is not found";
                baseResponse.Data = null;
                return baseResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Internal error, {ex.Message}");
                return new BaseResponse()
                {
                    StatusCode = ErrorCode.InternalError,
                    Message = $"Internal error, {ex.Message}"
                };
            }
        }

        public async Task<BaseResponse> GetAllUsers()
        {
            var baseResponse = new BaseResponse();
            try
            {
                var users = await _userRepository.Select();
                baseResponse.Data = users;
                if (users.Count() != 0)
                {
                    _logger.LogInformation($"Count users - {users.Count()}");
                    baseResponse.StatusCode = ErrorCode.OK;
                    return baseResponse;   
                }
                _logger.LogInformation("Users not found");
                baseResponse.StatusCode = ErrorCode.OK;
                baseResponse.Message = "Users not found";
                return baseResponse;   
            }
            catch (Exception ex)
            {
                _logger.LogError($"Internal error, {ex.Message}");
                return new BaseResponse()
                {
                    StatusCode = ErrorCode.InternalError,
                    Message = $"Internal error, {ex.Message}"
                };
            }
        }
    }
}
