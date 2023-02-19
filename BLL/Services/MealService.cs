using DAL;
using DAL.Repostories;
using Entities.Concrete;
using Entities.Dtos.MealDtos;
using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MealService : BaseRepository<Meal>
    {
        public MealService(DbContext context) : base(context)
        {
        }
        Context context = new Context();
        public List<MealViewModel> MealList()
        {
            List<MealViewModel> mealList = new List<MealViewModel>();

            foreach (Meal item in GetAll())
            {
                MealViewModel mealViewModel = new MealViewModel()
                {
                    Id = item.Id,
                    MealTypeName = item.MealType.Name,
                };
                mealList.Add(mealViewModel);
            }
            return mealList;
        }
        public void AddMeal(MealCreateDTO meal)
        {

            Meal newMeal = new Meal() { MealTypeID = meal.MealTypeId, UserID = meal.UserId, State = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now };
            Add(newMeal);
        }
        public void UpdateMeal(Meal meal)
        {
            Update(meal);
        }
        public void DeleteMeal(Meal meal)
        {
            Delete(meal);
        }
        
        public List<MealViewModel> GetAllMeals()
        {
<<<<<<< HEAD
            List<MealViewModel> MealVmList = new List<MealViewModel>();

            return FoodsVmList;
        }
        public Meal GetMealById(int id)
        {
            return GetById(id);
        }
        //public MealDetailsViewModel GetMealByDate(DateTime dateTime,User user,int mealTypeId)
        //{           
        //        DateTime date = dateTime;
        //        var getMealByDate = context.Meals
        //            .Where(md => md.CreatedDate == date && md.UserID == user.Id && md.MealTypeID==mealTypeId)                    
        //            .Select(g => new
        //            {
        //                g.f,g.Gram,g.Meal.MealDetails

        //            }).ToList();
        //    getMealByDate as List<MealDetailsViewModel>
        //        return;
        //}
=======
            List<MealViewModel> MealsVmList = new List<MealViewModel>();

            foreach (Meal item in GetAll())
            {
                MealViewModel mealViewModel = new MealViewModel()
                {
                    Id = item.Id,
                    Date=item.CreatedDate,
                    MealTypeName=item.MealType.Name,                    

                };
                MealsVmList.Add(mealViewModel);
            }
            return MealsVmList;
        }
            public Meal GetMealById(int id)
        {            
            return GetById(id);
        }
        public List<Meal> GetMealsByDate(DateTime date, User user, int mealTypeId)
        {
            
            return context.Meals
                          .Where(m => m.CreatedDate.Date == date.Date && m.UserID == user.Id && m.MealTypeID == mealTypeId)
                          .ToList();
            
        }
        public int GetMealIdByMeal(Meal meal)
        {

            int id = meal.Id;
                               
            
                return id ;
        }
>>>>>>> 7c4c9c83bdc0e5b1918e0ab92f69b47e325ea192

    }
}
