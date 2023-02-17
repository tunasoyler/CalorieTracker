using DAL.Repostories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FoodService : BaseRepository<Food>
    {
        public FoodService(DbContext context) : base(context)
        {
        }

        public List<Food> FoodList()
        {
            return GetAll().Select(x => new Food { Id = x.Id, Name=x.Name, Calorie=x.Calorie, Image=x.Image }).ToList();
        }
        public void AddFood(Food food)
        {
            Add(food);
        }
        public void UpdateFood(Food food)
        {
            Update(food);
        }
        public void DeleteFood(Food food)
        {
            Delete(food);
        }
        public Food GetFoodById(int id)
        {
            return GetById(id);
        }
        public List<Food> GetAllFoods()
        {
            return GetAll();
        }
    }
}
