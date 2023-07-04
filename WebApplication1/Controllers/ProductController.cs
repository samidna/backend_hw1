using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Model="Iphone 14",Year=2022,Description="Phone"},
                new Product{Id=2,Model="Samsung",Year=2018,Description="TV"},
                new Product{Id=3,Model="BMW",Year=2023,Description="Car"},
                new Product{Id=4,Model="GTA 5",Year=2017,Description="Video Game CD"},
            };

            ViewBag.Products = products;

            return View();
        }
    }
}
