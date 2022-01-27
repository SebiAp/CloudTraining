using Centric.eCommerce.Product.Api.Models;

namespace Centric.eCommerce.Product.Api.Interfaces;

public interface IProductProvider
{
    Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    Task<(bool IsSuccess, ProductModel Product, string ErrorMessage)> GetProductsAsync()
    {
        throw new NotImplementedException();
    }
}