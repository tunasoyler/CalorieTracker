using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DAL.Configurations
{
    public class ActivityTypeConfig : IEntityTypeConfiguration<ActivityType>
    {
        public void Configure(EntityTypeBuilder<ActivityType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new ActivityType
                //                Sedentary(little or no exercise, desk job)
                //Lightly active(light exercise 1 - 3 days / week)
                //Moderately active(moderate exercise 2 - 4 days / week)
                //Very active(hard exercise every day)
                //Extra active(hard exercise 2 or more times per day)
                {
                    Id = 1,
                    Name = "Sedentary",
                    ActivityMultiplier = 1.2,

                },
                new ActivityType
                {
                    Id = 2,
                    Name = "Lightly active",
                    ActivityMultiplier = 1.375,
                },
                new ActivityType
                {
                    Id = 3,
                    Name = "Moderately active",
                    ActivityMultiplier = 1.55,

                },
                new ActivityType
                {
                    Id = 4,
                    Name = "Very active",
                    ActivityMultiplier = 1.725,

                },
                new ActivityType
                {
                    Id = 5,
                    Name = "Extra active",
                    ActivityMultiplier = 1.9,

                });
        }

    }
}
