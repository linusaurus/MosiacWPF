using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations
{
    public class GlobalsConfig : IEntityTypeConfiguration<Globals>
    {
        public void Configure(EntityTypeBuilder<Globals> entity)
        {
            entity.HasKey(p => p.GiD);
        }
    }
}