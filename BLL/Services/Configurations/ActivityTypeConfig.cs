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
    public class ActivityTypeConfig : IEntityTypeConfiguration<ActivityType>
    {
        public void Configure(EntityTypeBuilder<ActivityType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new ActivityType
                {
                    Id = 1,
                    Name = "Active1",
                    ActivityMultiplier=1.15,
                    
                },
                new ActivityType
                {
                    Id = 2,
                    Name = "Active2",
                    ActivityMultiplier = 1.20,
                },
                new ActivityType
                {
                    Id = 3,
                    Name = "Active3",
                    ActivityMultiplier = 1.25,

                },
                new ActivityType
                {
                    Id = 4,
                    Name = "Active4",
                    ActivityMultiplier = 1.30,

                },
                new ActivityType
                {
                    Id = 5,
                    Name = "Active5",
                    ActivityMultiplier = 1.35,

                });
        }
    }
}
