using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class FavouritesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}