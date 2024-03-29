using Microsoft.AspNetCore.Mvc;

namespace TeamHost.Controllers;

public class WalletController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}