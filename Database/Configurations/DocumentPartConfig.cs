using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class DocumentPartConfig : IEntityTypeConfiguration<DocumentParts>
    {
        public  void  Configure( EntityTypeBuilder<DocumentParts> entity)
        {
            entity.HasKey(p => new { p.DocID, p.PartID });

            //---------------------------------------------
            // Relationships

           
        }
    }
}
