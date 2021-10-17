using ASPLesson.DAL.Repositories;
using ASPLesson.Domain.Interfaces.Repositories;
using ASPLesson.Domain.Interfaces.Services;
using ASPLesson.Domain.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ASPLesson
{
    public static class Initializer
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IModelService, ModelService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ILoginService, LoginService>();
        }
    }
}