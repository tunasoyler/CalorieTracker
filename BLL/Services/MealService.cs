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
        public List<Meal> MealList()
        {
            return GetAll().Select(x => new Meal { Id = x.Id, MealType=x.MealType}).ToList();
        }
        public void AddMeal(MealCreateDTO meal)
        {

            Meal newMeal = new Meal() { MealTypeID = meal.MealTypeId, UserID = meal.UserId ,State=true, CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now };
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
        public MealViewModel GetMealListById(int id)
        {
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

    }
}
