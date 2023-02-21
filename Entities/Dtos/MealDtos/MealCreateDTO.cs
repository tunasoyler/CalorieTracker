using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MealDtos
{
    public class MealCreateDTO
    {
        public int MealTypeId { get; set; }
        public int UserId { get; set; }
    }
}
