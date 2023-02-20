using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class MealDetailConfig : IEntityTypeConfiguration<MealDetails>
    {
        public void Configure(EntityTypeBuilder<MealDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Food).WithMany(x => x.MealDetails).HasForeignKey(x => x.FoodId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Meal).WithMany(x => x.MealDetails).HasForeignKey(x => x.MealId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.Gram).IsRequired();
            builder.Property(x => x.CreatedDate).HasConversion(typeof(DateTime));
            builder.Property(x => x.UpdatedDate).HasConversion(typeof(DateTime));
        }
    }
}
