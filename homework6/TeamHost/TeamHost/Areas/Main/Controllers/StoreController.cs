using Microsoft.AspNetCore.Mvc;
using TeamHost.Interfaces;

namespace TeamHost.Areas.Main.Controllers;
[Area("Main")]
public class StoreController : Controller
{
    private readonly IStoreService _storeService;

    public StoreController(IStoreService storeService)
    {
        _storeService = storeService;
    }
    public async Task<IActionResult> Index()
    {
        var games = await _storeService.GetAllGames(); 

        return View(games); 
    }
    
    [HttpGet("Store/item/{id}")]
    public IActionResult Details([FromRoute] int id)
    {
        var game = _storeService.GetGameById((uint)id); 

        return View(game); 
    }
}