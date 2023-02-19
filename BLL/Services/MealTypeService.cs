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
    public class MealTypeService : BaseRepository<MealType>
    {
        public MealTypeService(DbContext context) : base(context)
        {
        }
        public List<MealTypeViewModel> GetAllMealTypes()
        {
            List<MealTypeViewModel> mealTypeVmList = new List<MealTypeViewModel>();
            foreach (MealType item in GetAll())
            {

                MealTypeViewModel mealTypeVm = new MealTypeViewModel()
                {
                    Id= item.Id,
                    Name = item.Name

                };
                mealTypeVmList.Add(mealTypeVm);
            }
            return mealTypeVmList;
        }
    }
}
