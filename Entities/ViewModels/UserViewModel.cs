using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public DateTime? BirthDate { get; set; }
        public Genders Gender { get; set; }
        public double BMR { get; set; }
        public double DailyCalorieLimit { get; set; }
        public string? Timeline { get; set; }
        public double? Weight { get; set; }


    }
}
