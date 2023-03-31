using Catalog.Apis.Entities;

namespace Catalog.Apis.Repository
{
    public interface IProductRepository
    {

        // CRUD + By name + By category name

        Task CreateProduct(Product product);
        Task<IEnumerable<Product>> GetProducts();
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string Id);

        Task<Product> GetProductById(string Id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategoryName(string categoryName);
    }
}
