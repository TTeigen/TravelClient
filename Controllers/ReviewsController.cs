using System;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class ReviewsController : Controller
    {

        public IActionResult Delete(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(id);
            Console.ResetColor();
            
            Review.DeleteReview(id);
            return RedirectToAction("Index");
        }
        public IActionResult Create(int id)
        {
            ViewBag.DestinationId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            
            Review.AddReview(review);
            return RedirectToAction("Index", "Destinations");
        }
    }
}