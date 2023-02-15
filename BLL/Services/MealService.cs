using DAL.Repostories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MealService : BaseRepository<Meal>
    {
        public List<Meal> MealList()
        {
            return GetList().Select(x => new Meal { Id = x.Id, MealType=x.MealType}).ToList();
        }
        public static void Create(Meal meal)
        {
                       
        }
    }
}
