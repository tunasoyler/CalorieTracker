using Entities.Concrete;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.UserDtos
{
    public class UserCreateDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genders Gender { get; set; }
        public ActivityType ActivityType { get; set; }
        public double GoalWeight { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Timeline { get; set; }
        public double BMR { get; set; }
        public double DailyCalorieLimit { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
