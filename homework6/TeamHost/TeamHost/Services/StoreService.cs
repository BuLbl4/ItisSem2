using Microsoft.EntityFrameworkCore;
using TeamHost.Context;
using TeamHost.Interfaces;
using TeamHost.Models;

namespace TeamHost.Services;

public class StoreService : IStoreService
{
    private readonly ApplicationDbContext _dbContext;

    public StoreService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<GameResponse>> GetAllGames()
    {
        var games = await _dbContext.Games.AsNoTracking()
            .Include(g => g.GameCategories)
            .ThenInclude(gc => gc.Category)
            .Include(g => g.GamePlatforms)
            .ThenInclude(gp => gp.Platform)
            .ToListAsync();

        if (games.Count == 0)
            return new List<GameResponse>();
        
        var gameResponses = games.Select(game => new GameResponse
        {
            Id = (int)game.Id,
            Name = game.Name,
            Price = game.Price,
            Rating = game.Rating,
            MainImagePath = game.StaticFilePath,
            Categories = game.GameCategories.Select(gc => gc.Category.Name).ToList(),
            Platforms = game.GamePlatforms.Select(gp => new PlatformResponse
            {
                Name = gp.Platform.Name
            }).ToList()
        }).ToList();

        return gameResponses;
    }

    public GameResponse GetGameById(uint id)
    {
        var game = _dbContext.Games
            .AsNoTracking()
            .Include(g => g.Platforms)
            .Include(g => g.GameCategories)
            .Include(g => g.GamePlatforms)
            .Where(g => g.Id == id);

        if (!game.Any())
            return new GameResponse();

        var gameResponse = game.Select(g => new GameResponse
        {
            Id = (int)g.Id,
            Name = g.Name,
            Price = g.Price,
            MainImagePath = g.StaticFilePath,
            Rating = g.Rating,
            Categories = g.GameCategories.Select(gc => gc.Category.Name).ToList(),
            Platforms = g.Platforms.Select(platform => new PlatformResponse
            {
                Code = platform.Code,
                Name = platform.Name,
                ImagePath = platform.Image!.Path
            }).ToList(),
            Developer = g.Developer.Name,
            Description = g.Description
        }).ToArray();

        return gameResponse[0];
    }
}