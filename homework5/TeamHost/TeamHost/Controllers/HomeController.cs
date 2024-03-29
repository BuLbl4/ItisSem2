using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}