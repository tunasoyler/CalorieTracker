using DAL.Configurations;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetails> MealDetails { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet <ActivityType> ActivityTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-81CS8R3;database=CalorieTrackerDB;trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodConfig()).ApplyConfiguration(new MealConfig())
                .ApplyConfiguration(new MealDetailConfig()).ApplyConfiguration(new MealTypeConfig())
                .ApplyConfiguration(new UserConfig()).ApplyConfiguration(new ActivityTypeConfig()).ApplyConfiguration(new GenderConfig()).ApplyConfiguration(new UserTypeConfig());
        }
    }
}
