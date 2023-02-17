using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Gender).WithMany(x => x.Users).HasForeignKey(x => x.GenderId);
            builder.HasOne(x=>x.UserType).WithMany(x=>x.Users).HasForeignKey(x => x.UserTypeId);
            builder.Property(x => x.UserTypeId).HasDefaultValue(2);
            builder.HasOne(x => x.ActivityType).WithMany(x => x.Users).HasForeignKey(x => x.ActivityTypeId);
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar").HasMaxLength(25);
            builder.Property(x => x.Password).IsRequired().HasColumnType("varchar").HasMaxLength(25);
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.BirthDate).HasConversion(typeof(DateTime)).IsRequired();
            builder.HasData(
                new User
                {
                    Id= 1,
                    Name="admin",
                    Password="admin",
                    UserTypeId=1,
                    FirstName="admin",
                    LastName="admin",
                    ActivityTypeId=1,
                    BirthDate=DateTime.Now,
                    GenderId=1,
                    Height=1,
                    Weight=1,
                    BMR=1,

                });
                
        }
    }
}
