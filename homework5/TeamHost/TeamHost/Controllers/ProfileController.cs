using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}