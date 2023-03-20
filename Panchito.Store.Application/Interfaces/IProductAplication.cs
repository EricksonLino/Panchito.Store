﻿using Panchito.Store.Application.Dtos;

namespace Panchito.Store.Application.Interfaces
{
    public interface IProductAplication
    {
        Task<List<ProductDto>> GetProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
    }
}
