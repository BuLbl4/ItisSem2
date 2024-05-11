using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamHost.Entity;

namespace TeamHost.Configurations;

public class GameCategoryConfigurations : IEntityTypeConfiguration<GameCategory>
{
    public void Configure(EntityTypeBuilder<GameCategory> builder)
    {
        builder.HasKey(gc => new { gc.GameId, gc.CategoryId });
    }
}