using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class MarketController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}