using Microsoft.EntityFrameworkCore;
using PokemonAPI.DataAccess.Entities;

namespace PokemonAPI.DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Pokemon> Pokemons { get; set; }
        
    public DbSet<Abilities> Abilities { get; set; }
    
    public DbSet<Breeding> Breedings { get; set; }
        
    public DbSet<Moves> Moves { get; set; }
    
    public DbSet<Stats> Stats { get; set; }
        
    public DbSet<Types> Types { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }
}