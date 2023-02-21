using DataAccess.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context :DbContext
    {
        public DbSet<Food> Food { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<MealDetails> MealDetail { get; set; }
        public DbSet<MealType> MealType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EFOB25G;database=CalorieTrackerDB;trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodConfiguration()).ApplyConfiguration(new MealConfiguration())
                .ApplyConfiguration(new MealConfiguration()).ApplyConfiguration(new MealTypeConfiguration())
                .ApplyConfiguration(new UserConfiguration());
        }
    }
}
