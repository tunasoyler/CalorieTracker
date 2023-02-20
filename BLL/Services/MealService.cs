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

            Meal newMeal = new Meal() { Name="meal" ,MealTypeID = meal.MealTypeId, UserID = meal.UserId, State = true, CreatedDate=DateTime.Now.Date,UpdatedDate=DateTime.Now.Date};
            Add(newMeal);
        }
        public void UpdateMeal(Meal meal)
        {
            Update(meal);
        }
        public void DeleteMeal(MealDeleteDTO meal)
        {
            var deleteMeal = GetById(meal.Id);
            Delete(deleteMeal);
        }

        public List<MealViewModel> GetAllMeals()
        {
            List<MealViewModel> MealsVmList = new List<MealViewModel>();

            foreach (Meal item in GetAll())
            {
                MealViewModel mealViewModel = new MealViewModel()
                {
                    Id = item.Id,
                    Date = item.CreatedDate,
                    MealTypeName = item.MealType.Name,

                };
                MealsVmList.Add(mealViewModel);
            }
            return MealsVmList;
        }
        public Meal GetMealById(int id)
        {            
            return GetById(id);
        }
        public List<MealViewModel> GetMealsByDate(DateTime date)
        {
            List<MealViewModel> MealVmList = new List<MealViewModel>();
            
            foreach (Meal item in GetAll())
            {
                string mealType = context.MealTypes.Where(f => f.Id == item.MealTypeID).FirstOrDefault().Name;
                MealViewModel mealViewModel = new MealViewModel()
                {
                    Id = item.Id,
                    MealTypeName= mealType,
                    Date = date.Date

                };
                MealVmList.Add(mealViewModel);
            }
            return MealVmList;
            
            
        }
        public Meal GetMealByDateAndMealType(DateTime date, User user, int mealTypeId)
        {

            return context.Meals
                          .Where(m => m.CreatedDate.Date == date.Date && m.UserID == user.Id && m.MealTypeID == mealTypeId).FirstOrDefault();

        }     

    }
}
