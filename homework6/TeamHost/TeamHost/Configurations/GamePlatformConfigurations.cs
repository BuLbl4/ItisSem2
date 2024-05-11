using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeamHost.Entity;

namespace TeamHost.Configurations;

public class GamePlatformConfigurations : IEntityTypeConfiguration<GamePlatform>
{
    public void Configure(EntityTypeBuilder<GamePlatform> builder)
    {
        builder.HasKey(gc => new { gc.GameId, gc.PlatformId });
    }
}