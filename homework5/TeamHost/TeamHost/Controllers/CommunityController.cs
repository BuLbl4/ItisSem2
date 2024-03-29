using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class CommunityController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}