using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class DestinationsController : Controller
    {
        public IActionResult Index()
        {
            var allDestinations = Destination.GetAllDestinations();
            return View(allDestinations);
        }
    }
}