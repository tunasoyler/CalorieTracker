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
            double mealCalorie = mealDetails.Gram*mealDetails.Food.Calorie;
            
            return mealCalorie;
        }

        public double GetTotalCalorieByMeal(MealDetails mealDetails)
        {
            FoodService foodService = new FoodService(context);
            MealService mealService = new MealService(context);

            var mealType = mealService.GetMealById(mealDetails.MealId).MealType;

            //foreach (var item in MealType
            //{
            //    var foodCalorie = foodService.GetById(mealDetails.FoodId).Calorie;
            //}





            return 1;
        }
        //public double TotalCalorieByDay { get; set; }
        //public double TotalCalorieByMeal { get; set; }



    }
}
