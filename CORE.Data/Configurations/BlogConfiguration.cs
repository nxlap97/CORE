

using CORE.Data.Extensions;
using CORE.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Data.Configurations
{
    public class BlogConfiguration : DbEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(128)
                .IsUnicode(false).HasMaxLength(128).IsRequired();
        }
    }
}
