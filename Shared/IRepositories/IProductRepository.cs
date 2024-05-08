using Shared.Models;

namespace Shared.IRepositories
{
    public interface IProductRepository
    {
        Task<List<Product>> Get();
        Task<Product> Get(int id);
        Task<Product> Add(Product model);
        Task<Product> Update(Product model);
        Task<Product> Delete(int id);
    }
}
