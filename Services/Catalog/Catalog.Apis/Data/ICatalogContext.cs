using Catalog.Apis.Entities;
using MongoDB.Driver;

namespace Catalog.Apis.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
