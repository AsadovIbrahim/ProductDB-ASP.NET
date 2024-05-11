using Microsoft.AspNetCore.Mvc;
using Product_Store.Repositories.Abstracts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
       
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {

            bool exist = false;
            foreach (var item in await _categoryRepository.GetAllAsync())
            {
                if (item.Name == category.Name)
                {
                    exist = true;
                }
            }
            if (!exist)
            {
                await _categoryRepository.AddAsync(category);
                return RedirectToAction("GetAllCategories");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return View(categories);
        }


    }
}
