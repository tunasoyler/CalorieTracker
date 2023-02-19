using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetailsDtos
{
    public class MealDetailsCreateDTO
    {
        public double Gram { get; set; }
        public int MealId { get; set; }
        public int FoodId { get; set; }
        
    }
}
