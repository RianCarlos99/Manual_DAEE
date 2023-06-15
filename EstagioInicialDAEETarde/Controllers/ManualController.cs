using Microsoft.AspNetCore.Mvc;

namespace WebMvcMysql.Controllers
{
    public class ManualController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
