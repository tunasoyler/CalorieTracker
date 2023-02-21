using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired().HasColumnType("varchar").HasMaxLength(25);
            builder.Property(x=>x.Password).IsRequired().HasColumnType("varchar").HasMaxLength(25);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.BirthDate).HasConversion(typeof(DateTime)).IsRequired();
        }
    }
}
