using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PartConfig : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> entity)
        {
            entity.HasKey(p => p.PartID);
           // entity.HasOne(m => m.Manu).WithOne().HasPrincipalKey();
        }
    }
}