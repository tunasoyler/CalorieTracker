using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class MealConfig : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.MealDetails).WithOne(x => x.Meal).HasForeignKey(x => x.MealId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.User).WithMany(x => x.Meals).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.MealType).WithMany(x => x.Meals).HasForeignKey(x => x.MealTypeID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.CreatedDate).HasConversion(typeof(DateTime));
            builder.Property(x => x.UpdatedDate).HasConversion(typeof(DateTime));
        }
    }
}
