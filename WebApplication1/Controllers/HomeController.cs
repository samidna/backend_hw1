using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            return Content("Welcome to store!");
        }
        public ContentResult About()
        {
            return new ContentResult { Content = "About Page!" };
        }

        public ViewResult Contact()
        {
            return View();
        }

        public JsonResult Show()
        {
            return Json(new { name = "Smart", type = "Electronics", startDate = DateTime.UtcNow.ToString("dd.mm.yyy") });
        }
    }
}
