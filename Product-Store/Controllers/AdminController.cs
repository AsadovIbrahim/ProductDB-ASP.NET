using Microsoft.AspNetCore.Mvc;

namespace Product_Store.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
