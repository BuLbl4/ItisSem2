using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class ReportController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}