using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class FoodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public double Calorie { get; set; }
        public byte[] Image { get; set; }
        public override string ToString()
        {
            return $"{this.Name},{this.Calorie} kcal(Per gr.)";
        }
    }
    
}
