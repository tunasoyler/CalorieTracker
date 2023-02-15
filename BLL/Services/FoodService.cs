using DAL.Repostories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FoodService : BaseRepository<Food>
    {
        public List<Food> FoodList()
        {
            return GetList().Select(x => new Food { Id = x.Id, Name=x.Name, Calorie=x.Calorie, Image=x.Image }).ToList();
        }
    }
}
