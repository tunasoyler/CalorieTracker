using DAL;
using DAL.Repostories;
using Entities.Concrete;
using Entities.ViewModels;
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

        Context context = new Context();

        public List<MealDetailsViewModel> MealDetailList()
        {
            List<MealDetails> mealDetails = new List<MealDetails>();
            List<MealDetailsViewModel> mealDetailVms = new List<MealDetailsViewModel>();

            foreach (var item in GetAll())
            {
                MealDetailsViewModel mealDetailVm = new MealDetailsViewModel()
                {
                    Gram = item.Gram,
                    MealType = item.Meal.MealType.Name,
                    Id = item.Id,
                    Food = item.Food.Name,
                    Calorie = item.Food.Calorie,
                    Image = item.Food.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }
            return mealDetailVms;
        }

        public double GetMealCalorieByMealType(MealDetails mealDetails)
        {
            double mealCalorie = mealDetails.Gram * mealDetails.Food.Calorie;

            return mealCalorie;
        }

        //public List<object> GetTotalCalorieByMeal(MealDetails mealDetails, DateTime dateTime, User user)
        //{
        //    DateTime date = dateTime;

        //    var SumCalorieByMeal = context.MealDetails
        //        .Where(md => md.Meal.CreatedDate == date && md.Meal.UserID == user.Id)
        //        .GroupBy(md => md.Meal.MealType)
        //        .Select(g => new 
        //        { 
        //            MealId = mealDetails.MealId, MealName = mealDetails.Meal.Name,
        //            FoodCalories = g.Sum(md => md.Food.Calorie * md.Gram) 
        //        }).ToList();


        //    return SumCalorieByMeal.Cast<object>().ToList();
        //}
        //public double TotalCalorieByDay { get; set; }
        //public double TotalCalorieByMeal { get; set; }



    }
}
