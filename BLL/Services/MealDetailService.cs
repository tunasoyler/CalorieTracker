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
    public class MealDetailService : BaseRepository<MealDetails>
    {
        public MealDetailService(DbContext context) : base(context)
        {

        }

        
                

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



    }
}
