using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class GamesStoreController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}