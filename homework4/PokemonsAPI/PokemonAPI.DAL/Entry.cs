using Microsoft.Extensions.DependencyInjection;
using PokemonAPI.Core.Inrerfaces;
using PokemonAPI.DAL.EfCore;

namespace PokemonAPI.DAL;

public static class Entry
{
    public static IServiceCollection AddPostgreSqlCore(this IServiceCollection serviceCollection)
    {
        if (serviceCollection is null)
            throw new ArgumentNullException(nameof(serviceCollection));

        serviceCollection.AddDbContext<AppDbContext>();
        serviceCollection.AddScoped<IDbContext, AppDbContext>();

        return serviceCollection;
    }
}