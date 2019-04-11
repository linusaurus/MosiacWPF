using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class TransActionTypeConfig : IEntityTypeConfiguration<TransActionType>
    {
        public void Configure(EntityTypeBuilder<TransActionType> entity)
        {
            entity.HasKey(p => p.TransactionsTypeID);
        }
    }
}