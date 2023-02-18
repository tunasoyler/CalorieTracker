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
    public class MealService : BaseRepository<Meal>
    {
        public MealService(DbContext context) : base(context)
        {
        }

        public List<Meal> MealList()
        {
            return GetAll().Select(x => new Meal { Id = x.Id, MealType=x.MealType}).ToList();
        }
        public void AddMeal(Meal meal)
        {
            Add(meal);
        }
        public void UpdateMeal(Meal meal)
        {
            Update(meal);
        }
        public void DeleteMeal(Meal meal)
        {
            Delete(meal);
        }
        public Meal GetMealById(int id)
        {
            return GetById(id);
        }
        public List<MealViewModel> GetAllMeals()
        {
            List<MealViewModel> mealVmList = new List<MealViewModel>();
            foreach (Meal item in GetAll())
            {
                
                MealViewModel mealViewModel = new MealViewModel()
                {
                   
                    MealTypeName=item.MealType.Name

                };
                mealVmList.Add(mealViewModel);
            }
            return mealVmList;
        }
        
    }
}
