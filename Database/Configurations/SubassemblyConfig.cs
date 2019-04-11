using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class SubAssemblyConfig : IEntityTypeConfiguration<SubAssembly>
    {
        public void Configure(EntityTypeBuilder<SubAssembly> entity)
        {
            entity.HasKey(p => p.SubAssemblyID);

           
        }
    }
}