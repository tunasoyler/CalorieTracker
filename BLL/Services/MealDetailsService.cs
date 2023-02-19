using DAL;
using DAL.Repostories;
using Entities.Concrete;
using Entities.Dtos.MealDetailsDtos;
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
        public List<MealDetails> GetFoodByMealType(DateTime date, User user, int mealTypeId)
        {

            return         GetAll()
                          .Where(m => m.CreatedDate.Date == date.Date && m.Meal.UserID == user.Id && m.Meal.MealTypeID==mealTypeId).ToList();

        }
        public List<MealDetailsViewModel> GetFoodsByMealType(DateTime dateTime, User user, int mealTypeId)
        {           
            List<MealDetailsViewModel> mealDetailVms = new List<MealDetailsViewModel>();
            List<MealDetails> mealDetailsList = new List<MealDetails>();
            mealDetailsList = context.MealDetails
                          .Where(m => m.CreatedDate.Date == dateTime.Date && m.Meal.UserID == user.Id && m.Meal.MealTypeID == mealTypeId).ToList();

            foreach (var item in mealDetailsList)
            {
                MealDetailsViewModel mealDetailVm = new MealDetailsViewModel()
                {
                    Food = (context.Foods.Where(f=>f.Id==item.FoodId).FirstOrDefault()).Name,
                    Gram = item.Gram,
                    Calorie = (context.Foods.Where(f => f.Id == item.FoodId).FirstOrDefault()).Calorie * item.Gram,
                    Image = item.Food.Image
                };
                mealDetailVms.Add(mealDetailVm);
            }           
            return mealDetailVms;
        }

        public void AddMealDetail(MealDetailsCreateDTO mealDetails)
        {
            MealDetails newMealDetails = new MealDetails {Name="meal", Gram = mealDetails.Gram, MealId = mealDetails.MealId, FoodId = mealDetails.FoodId, CreatedDate= DateTime.Now,UpdatedDate=DateTime.Now};
            Add(newMealDetails);
        }

        

        public double GetMealCalorieByMealType(MealDetails mealDetails)
        {
            double mealCalorie = mealDetails.Gram * mealDetails.Food.Calorie;

            return mealCalorie;
        }
        public double GetMealCalorieByMeal(Meal meal)
        {
            List<MealDetails> mealDetails = new List<MealDetails>();

            double totalMealCalorie = 0;

            foreach (var item in mealDetails)
            {
                totalMealCalorie += item.Gram * item.Food.Calorie;
            }

            return totalMealCalorie;
        }
        public List<FoodCountByMealViewModel> GetFoodsWithCount()
        {
            List<FoodCountByMealViewModel> foodList = new List<FoodCountByMealViewModel>();


            foreach (MealDetails item in GetAll())
            {
                FoodCountByMealViewModel food = new FoodCountByMealViewModel()
                {
                    Name = item.Food.Name,
                    Count = context.MealDetails.Count(x => x.Food.Name == item.Food.Name),
                    Image = item.Food.Image
                };

                foodList.Add(food);
            }

            return foodList;
        }
        public void DeleteMeal(MealDetailsDeleteDTO meal)
        {
            var deleteMeal = GetById(meal.Id);
            Delete(deleteMeal);
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

        public double TotalCalorieByDay { get; set; }
        public double TotalCalorieByMeal { get; set; }



    }
}
