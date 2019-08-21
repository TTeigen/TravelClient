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

        public IActionResult Details(int id)
        {
            var destinationDeets = Destination.GetDestinationDetails(id);
            var reviewList = destinationDeets.Reviews;
            ViewBag.reviews = reviewList;
            return View(destinationDeets);
        }

        public IActionResult Delete(int id)
        {
            var allDestinations = Destination.DeleteDestination(id);
            return RedirectToAction("Index");
        }
    }
}