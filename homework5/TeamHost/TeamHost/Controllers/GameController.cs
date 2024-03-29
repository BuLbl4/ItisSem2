using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class GameController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}