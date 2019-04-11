using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PurchaseLineItemConfig : IEntityTypeConfiguration<PurchaseLineItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseLineItem> entity)
        {
            entity.HasKey(p => p.LineID);

            //-----------------------------------
            // Relationships

           
        }
    }
}
