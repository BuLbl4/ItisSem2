using PokemonAPI.Core.Entity;

namespace PokemonAPI.Core.Inrerfaces;

public interface IPokemonRepository
{
    Task<List<Pokemon>> GetAll();
    
    Task<Pokemon> GetByOrder(int order);
    
    Task<Pokemon> GetById(Guid id);
    
    Task<Pokemon> GetByName(string name);
}