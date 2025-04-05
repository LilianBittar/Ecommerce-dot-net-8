using Catalog.Core.Entities;

namespace Catalog.Infrastructure.Repo
{
    public interface IProductRepo
    {
        Task<Product> CreateProduct(Product product);
        Task<bool> DeleteProduct(string id);
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> getProductByBrand(string brand);
        Task<IEnumerable<Product>> getProductByName(string name);
        Task<bool> updateProduct(Product product);
    }
}