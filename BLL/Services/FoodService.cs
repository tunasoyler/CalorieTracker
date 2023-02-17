using DAL.Repostories;
using Entities.Concrete;
using Entities.Dtos.FoodDtos;
using Entities.ViewModels;
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
        public void AddFood(FoodCreateDTO food)
        {
            Food newfood= new Food { Name=food.FoodName, Calorie=food.Calorie, Image=food.Image };
            Add(newfood);
        }
        public void UpdateFood(FoodUpdateDTO food)
        {
            Food updateFood = new Food { Name = food.FoodName, Calorie = (double)food.Calorie, Image = food.Image };
            Update(updateFood);
        }
        //public void DeleteFood(FoodDeleteDTO food)
        //{
        //    Delete();
        //}
        public Food GetFoodById(int id)
        {
            return GetById(id);
        }
        public List<FoodViewModel> GetAllFoods()
        {
            List<FoodViewModel> FoodsVmList = new List<FoodViewModel>();

            foreach (Food item in GetAll())
            {
                FoodViewModel foodViewModel = new FoodViewModel()
                {
                    Name= item.Name,
                    Calorie= item.Calorie,
                    Image= item.Image
                    
                };
                FoodsVmList.Add(foodViewModel);
            }
            return FoodsVmList;
            
        }
    }
}
