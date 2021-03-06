﻿namespace Levelnis.Learning.CallingWebApiFromMvc.Web.ApiInfrastructure.Client
{
    using System.Threading.Tasks;
    using Models;
    using Responses;

    public interface IProductClient
    {
        Task<CreateProductResponse> CreateProduct(ProductViewModel product);
        Task<ProductResponse> GetProduct(int productId);
    }
}