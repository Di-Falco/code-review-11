using Microsoft.AspNetCore.Mvc;

namespace Pierre.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Title = "Pierre's Bakery";
        ViewBag.Subtitle = "Home";
        return View();
      }

    }
}