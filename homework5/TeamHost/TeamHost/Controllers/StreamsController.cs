using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class StreamsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}