using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class FinishConfig : IEntityTypeConfiguration<Finish>
    {
        public void Configure(EntityTypeBuilder<Finish> entity)
        {
            entity.HasKey(p => p.FinishID);
        }
    }
}