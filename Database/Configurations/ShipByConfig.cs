using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ShipByConfig : IEntityTypeConfiguration<ShipBy>
    {
        public void Configure(EntityTypeBuilder<ShipBy> entity)
        {
            entity.HasKey(p => p.ShipID);
        }
    }
}