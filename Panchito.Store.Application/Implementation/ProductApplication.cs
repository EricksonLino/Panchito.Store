using AutoMapper;
using Panchito.Store.Application.Dtos;
using Panchito.Store.Application.Interfaces;
using Panchito.Store.Repository.Interfaces;

namespace Panchito.Store.Application.Implementation
{
    public class ProductApplication : IProductAplication
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductApplication(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var products = await this.productRepository.GetProductsAsync();

            var productsDto = this.mapper.Map<List<ProductDto>>(products);
            return productsDto;
        }
        public async  Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await this.productRepository.GetProductByIdAsync(id);

            var productDto = this.mapper.Map<ProductDto>(product);
              return productDto;
        }

        
    }
}
