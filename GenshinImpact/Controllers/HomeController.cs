using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenshinImpact.Models;
using GenshinImpact.Services;

namespace GenshinImpact.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly GenshinService _service;

    public HomeController(ILogger<HomeController> logger, GenshinService service)
    {
        _logger = logger;
        _service = service;
    }

    public IActionResult Index(string vision)
    {
        ViewData["filter"] = string.IsNullOrEmpty(vision) ? "all" : vision;
        return View(_service.GetIndexDto());
    }

    public IActionResult Details(string Name)
    {
        return View(_service.Characters.GetCharacter(Name));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
