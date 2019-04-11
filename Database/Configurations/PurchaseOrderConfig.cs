using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PurchaseOrderConfig : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> entity)
        {
            entity.HasKey(p => p.OrderNum);

            //------------------------------------------------
            // Relationships

            //entity.HasMany(c => c.PurchaseLineItems).WithOne()
            //    .HasForeignKey(k => k.PurchaseOrderID).IsRequired();
               
        }
    }
}
