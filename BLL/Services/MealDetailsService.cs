using DAL.Repostories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MealDetailsService : BaseRepository<MealDetails>
    {
        public MealDetailsService(DbContext context) : base(context)
        {
        }
        public double GetMealCalorieByMealType(MealDetails mealDetails)
        {
            double mealCalorie = mealDetails.Gram*mealDetails.Food.Calorie;
            
            return mealCalorie;
        }
    }
}
