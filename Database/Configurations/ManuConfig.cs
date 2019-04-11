using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class ManuConfig : IEntityTypeConfiguration<Manu>
    {
        public void Configure(EntityTypeBuilder<Manu> entity)
        {
            entity.HasKey(p => p.ManuID);
            entity.HasMany(m => m.Parts).WithOne().HasForeignKey(f => f.ManuID);
        }
    }
}