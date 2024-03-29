using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class FriendsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}