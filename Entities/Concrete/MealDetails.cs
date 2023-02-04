using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MealDetails
    {
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public int FoodId { get; set; }
        public virtual  Food Food { get; set;}
    }
}
