using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Repositories.Concretes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
