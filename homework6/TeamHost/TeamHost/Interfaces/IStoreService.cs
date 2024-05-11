using TeamHost.Models;

namespace TeamHost.Interfaces;

public interface IStoreService
{
    public Task<List<GameResponse>> GetAllGames();

    public GameResponse GetGameById(uint id);
}