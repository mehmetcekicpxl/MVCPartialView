using Microsoft.AspNetCore.Mvc;
using MVCPartialView.Models;

namespace MVCPartialView.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id=1, Name="Laptop", Price=2500 },
                new Product { Id=2, Name="Mouse", Price=120 },
                new Product { Id=3, Name="Toetsenbord", Price=350 },
            };

            return View(products);
        }
    }
}
