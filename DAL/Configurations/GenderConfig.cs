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
    public class GenderConfig : IEntityTypeConfiguration<Genders>
    {
        public void Configure(EntityTypeBuilder<Genders> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new Genders
                {
                    Id = 1,
                    Name = "Male"
                },
                new Genders
                {
                    Id = 2,
                    Name = "Female"
                });
            


        }
    }
}
