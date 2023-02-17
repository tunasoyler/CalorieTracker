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
    public class MealTypeConfig : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new MealType
                {
                    Id = 1,
                    Name = "Breakfast"
                },
                new MealType
                {
                    Id = 2,
                    Name = "Lunch"
                },
                new MealType
                {
                    Id = 3,
                    Name = "Dinner"
                },
                new MealType
                {
                    Id = 4,
                    Name = "Snack"
                });
        }
    }
}
