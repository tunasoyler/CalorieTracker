

using DAL.Repostories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : BaseRepository<User>
    {
        public List<User> UserList()
        {
            return GetList().Select(x => new User { Id = x.Id, UserType = x.UserType, Name = x.Name, FirstName = x.FirstName, LastName = x.LastName  }).ToList();
        }
        public List<User> UserDetailList()
        {
            return GetList().Select(x => new User { Gender = x.Gender, Height = x.Height, Weight=x.Weight, ActivityType = x.ActivityType, GoalWeight = x.GoalWeight,  BirthDate = x.BirthDate, BMR = x.BMR, CreatedDate=x.CreatedDate, UpdatedDate = x.UpdatedDate, Meals=x.Meals, Password=x.Password, State=x.State }).ToList();
        }
        public static void Create(User user)
        {

        }
    }
}
