using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
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
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserService> _logger;

        public LoginService(IUserRepository userRepository,
            ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }
        
        public async Task<BaseResponse> Login(LoginViewModel userModel)
        {
            var baseResponse = new BaseResponse();
            try
            {
                var user = await _userRepository.GetByName(userModel.Email);
                if (user != null)
                {
                    if (user.Password == HashPassword(userModel.Password))
                    {
                        GetClaim(user);   
                    }
                }
                baseResponse.StatusCode = ErrorCode.OK;
                baseResponse.Data = user;
                return baseResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Message: {ex.Message}");
                return new BaseResponse()
                {
                    StatusCode = ErrorCode.InternalError,
                    Message = "Ошибка произошла на стороне сервера"
                };
            }
        }
        
        public async Task<BaseResponse> Register(RegisterViewModel userModel)
        {
            var baseResponse = new BaseResponse();
            try
            {
                var user = await _userRepository.GetByName(userModel.Email);
                if (user == null)
                {
                    user = new User
                    {
                        Name = userModel.Name,
                        Email = userModel.Email,
                        Password = HashPassword(userModel.Password),
                    };
                    await _userRepository.Insert(user);
                }
                baseResponse.StatusCode = ErrorCode.OK;
                baseResponse.Data = user;
                return baseResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Message: {ex.Message}");
                return new BaseResponse()
                {
                    StatusCode = ErrorCode.InternalError,
                    Message = "Ошибка произошла на стороне сервера"
                };
            }
        }
        
        private ClaimsIdentity GetClaim(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };
            var claimId = new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            return claimId;
        }

        private string HashPassword(string password)
        {
            using (var md5 = new HMACMD5())
            {
                var data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
        }
    }
}