using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GrowApp.Models;

namespace GrowApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
