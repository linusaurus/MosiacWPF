using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class PartTypeConfig : IEntityTypeConfiguration<PartTypes>
    {
        public void Configure(EntityTypeBuilder<PartTypes> entity)
        {
            entity.HasKey(p => p.PartTypeID);
        }
    }
}