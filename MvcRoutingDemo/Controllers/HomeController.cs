using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcRoutingDemo.Models;

namespace MvcRoutingDemo.Controllers;

public class HomeController : Controller
{
    // Matches: /
    // Matches: /home
    // Matches: /home/index
    public IActionResult Index()
    {
        return Content("Home Index (Conventional Routing)");
    }

    // Matches: /home/about
    public IActionResult About()
    {
        return Content("About Page");
    }

    // Matches: /home/details/5
    public IActionResult Details(int id)
    {
        return Content($"Details for ID = {id}");
    }
}