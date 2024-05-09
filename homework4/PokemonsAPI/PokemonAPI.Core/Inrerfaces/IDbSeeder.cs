namespace PokemonAPI.Core.Inrerfaces;

public interface IDbSeeder
{
    Task SeedAsync(CancellationToken cancellationToken);
}