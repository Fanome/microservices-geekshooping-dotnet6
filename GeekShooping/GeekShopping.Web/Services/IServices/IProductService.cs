using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductsById(long id);
        Task<ProductModel> CreateProducts(ProductModel model);
        Task<ProductModel> UpdateProducts(ProductModel model);
        Task<bool> DeleteProductById(long id);
    }
}