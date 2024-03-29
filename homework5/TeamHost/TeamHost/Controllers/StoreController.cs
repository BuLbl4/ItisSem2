using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class StoreController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}