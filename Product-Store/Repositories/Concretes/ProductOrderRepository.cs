using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Repositories.Concretes
{
    public class ProductOrderRepository : GenericRepository<ProductOrder>, IProductOrdersRepository
    {
        public ProductOrderRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
