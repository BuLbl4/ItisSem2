using Microsoft.EntityFrameworkCore;
using TeamHost.Configurations;
using TeamHost.Entity;

namespace TeamHost.Context;


public class ApplicationDbContext: DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Platform> Platforms { get; set; }
    public DbSet<StaticFile> StaticFiles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<GameCategory> GameCategories { get; set; }
    public DbSet<GamePlatform> GamePlatforms { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new GameCategoryConfigurations());
        modelBuilder.ApplyConfiguration(new GamePlatformConfigurations());
        modelBuilder.ApplyConfiguration(new GameConfigurations());
        
        modelBuilder.Entity<Company>().HasData(DatabaseSeeder.Companies());
        modelBuilder.Entity<Category>().HasData(DatabaseSeeder.Categories());
        modelBuilder.Entity<Platform>().HasData(DatabaseSeeder.Platforms());
        modelBuilder.Entity<Country>().HasData(DatabaseSeeder.Countries());
        
    }
}