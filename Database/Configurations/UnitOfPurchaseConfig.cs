using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class UnitOfPurchaseConfig : IEntityTypeConfiguration<UnitOfPurchase>
    {
        public void Configure(EntityTypeBuilder<UnitOfPurchase> entity)
        {
            entity.HasKey(p => p.UoPID);
        }
    }
}

