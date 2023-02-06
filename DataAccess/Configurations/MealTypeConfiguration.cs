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
    public class MealTypeConfiguration : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new MealType
                {
                    Id = 1,
                    Name = "Kahvaltı"
                },
                new MealType
                {
                    Id = 2,
                    Name = "Öğle Yemeği"
                },
                new MealType
                {
                    Id = 3,
                    Name = "Akşam Yemeği"
                },
                new MealType
                {
                    Id = 4,
                    Name = "Ara Öğün"
                });
        }
    }
}
