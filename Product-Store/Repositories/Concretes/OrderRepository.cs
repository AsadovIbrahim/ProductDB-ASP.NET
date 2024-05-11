using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Repositories.Concretes
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
