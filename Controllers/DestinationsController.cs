using System;
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
            return View(destinationDeets);
        }

        public IActionResult Delete(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(id);
            Console.ResetColor();
            
            Destination.DeleteDestination(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destination destination)
        {
            Destination.AddDestination(destination);
            return View();
        }
    }
}