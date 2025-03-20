using Bulky.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace Bulky.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
