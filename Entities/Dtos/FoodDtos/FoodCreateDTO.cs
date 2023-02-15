using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.FoodDtos
{
    public class FoodCreateDTO
    {
        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public byte[] Image { get; set; }
        public bool State { get; set; }
    }
}
