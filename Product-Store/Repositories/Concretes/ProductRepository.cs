using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Repositories.Concretes
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
