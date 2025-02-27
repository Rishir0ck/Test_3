using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        // // GET: HomeController
        // public ActionResult Index()
        // {
        //     return View();
        // }

        public string Index()
        {
            return "Hello from Home Controller";
        }



    }
}
