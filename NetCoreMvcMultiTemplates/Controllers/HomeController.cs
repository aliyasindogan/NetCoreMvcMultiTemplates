using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvcMultiTemplates.Models;
using WebApplication1.Models;

namespace NetCoreMvcMultiTemplates.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWebHostEnvironment _env;

    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
    {
        _logger = logger;
        _env = env;
    }

    public IActionResult Index(int id = 1)
    {
        Template template = new Template();
        string getData = "";
        string url = "";
        url = id == 1 ? Constants.Navbar1Url : Constants.Navbar2Url;
        string filePath = Path.Combine(_env.WebRootPath, url);
        if (System.IO.File.Exists(filePath))
        {
            getData = System.IO.File.ReadAllText(filePath);
        }

        template.Navbar = getData.Replace("_firmaAdi", "AYD SOFTWARE").Replace("_anasayfa", "ANA SAYFA").Replace("_gizlilik", "Gizlilik");
        return View(template);
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
