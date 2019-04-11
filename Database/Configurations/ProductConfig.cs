using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(p => p.ProductID);

            //entity.HasMany(c => c.Product).WithOne()
           //   .HasForeignKey(k => k.ProductionGroupID).IsRequired();
        }
    }
}