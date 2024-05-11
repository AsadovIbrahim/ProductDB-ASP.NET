using Microsoft.AspNetCore.Mvc;
using Product_Store.Repositories.Abstracts;
using ProductDB.Contexts;
using ProductDB.Entities.Concretes;

namespace Product_Store.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            var existingProduct=await _productRepository.GetByIdAsync(product.Id);
            if(existingProduct == null) { 
                await _productRepository.AddAsync(product);
                return RedirectToAction("GetAllProducts");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products= await _productRepository.GetAllAsync();
            return View(products);
        }

        public IActionResult RemoveProduct() {      
            return View();
        }

        public IActionResult UpdateProduct() {
            return View();
        }

    }
}
