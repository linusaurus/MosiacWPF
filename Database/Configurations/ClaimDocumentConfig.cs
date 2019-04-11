using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{ 
    public class ClaimDocumentConfig : IEntityTypeConfiguration<ClaimDocument>
    {
        public void Configure(EntityTypeBuilder<ClaimDocument> entity)
        {
            entity.HasKey(p => p.ClaimDocumentID);
        }
    }
}