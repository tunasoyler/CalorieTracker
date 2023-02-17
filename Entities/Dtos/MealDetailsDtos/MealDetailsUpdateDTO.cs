using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDetailsDtos
{
    public class MealDetailsUpdateDTO
    {
        public int Id { get; set; }
        public double Gram { get; set; }
        public string MealTypeName { get; set; }
        public string FoodName { get; set; }
    }
}
