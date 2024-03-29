using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class ChatsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}