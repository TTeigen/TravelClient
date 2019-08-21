using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}