using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ClaimConfig : IEntityTypeConfiguration<Claim>
    {
        public void Configure(EntityTypeBuilder<Claim> entity)
        {
            entity.HasKey(p => p.ClaimID);

            //---------------------------------------------
            //Relationships

            
           // entity.HasMany(p => p.ClaimItems.Wirh().HasForeignKey(d => d.ClaimID)
           //    .IsRequired()
           //     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}