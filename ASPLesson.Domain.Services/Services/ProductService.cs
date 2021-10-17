using System;
using System.Linq;
using System.Threading.Tasks;
using ASPLesson.Domain.Dto;
using ASPLesson.Domain.Entity;
using ASPLesson.Domain.Entity.Reponse;
using ASPLesson.Domain.Enum;
using ASPLesson.Domain.Interfaces.Repositories;
using ASPLesson.Domain.Interfaces.Services;
using LogLevel = ASPLesson.Domain.Enum.LogLevel;

namespace ASPLesson.Domain.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogRepository _logRepository;
        private readonly IProductRepository _productRepository;
        private readonly IFileService _fileService;
        private readonly ILoggerService<ProductService> _loggerService;
        private readonly ILoggerDbService<ProductService> _loggerDbService;
        
        public ProductService(IProductRepository productRepository,
            ILogRepository logRepository,
            IFileService fileService)
        {
            _productRepository = productRepository;
            _fileService = fileService;
            _logRepository = logRepository;
            _loggerDbService = new LoggerDbService<ProductService>(logRepository);
            _loggerService = new LoggerService<ProductService>(fileService);
        }

        public async Task<BaseResponse> GetAllProducts()
        {
            var baseResponse = new BaseResponse();
            try
            {
                _loggerService.Log(LogLevel.Critical, "Hello, ITHomester", 500, new Exception());
                var products = await _productRepository.GetAllProducts();
                baseResponse.StatusCode = ErrorCode.OK;
                if (products.Count() != 0)
                {
                    _loggerService.LogInformation($"Количество продуктов - {products.Count()}");
                    baseResponse.Data = products;
                    return baseResponse;
                }
                
                return baseResponse;
            }
            catch (Exception ex)
            {
                _loggerService.Log(LogLevel.Error, $"Внутрення ошибка 500 {ex.Message}");
                return new BaseResponse()
                {
                    Message = ex.Message,
                    StatusCode = ErrorCode.InternalError
                };
            }
        }

        public async Task<BaseResponse> CreateProduct(CreateProductViewModel model)
        {
            var baseResponse = new BaseResponse();
            try
            {
                var product = await _productRepository.GetProduct(model.Name);
                baseResponse.StatusCode = ErrorCode.OK;
                if (product == null)
                {
                    product = new Product()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price
                    };
                    await _productRepository.Insert(product);
                    _loggerService.LogInformation($"Объект был добавлен - {product.Name}");

                    baseResponse.Data = product;
                    return baseResponse;
                }
                _loggerService.LogInformation($"Данный объект уже существует - {product.Name}");
                return baseResponse;
            }
            catch (Exception ex)
            {
                _loggerService.LogError($"Внутрення ошибка 500 {ex.Message}");
                return new BaseResponse()
                {
                    Message = ex.Message,
                    StatusCode = ErrorCode.InternalError
                };
            }
        }
        
    }
}