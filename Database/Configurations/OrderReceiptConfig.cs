using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class OrderReceiptConfig : IEntityTypeConfiguration<OrderReciept>
    {
        public void Configure(EntityTypeBuilder<OrderReciept> entity)
        {
            entity.HasKey(p => p.OrderReceiptID);
        }
    }
}
