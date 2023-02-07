

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
        //public List<User> UserList()
        //{
        //    return GetList().Select(x=>new User { Id=x.Id,UserType=x.UserType,Name=x.Name,FirstName=x.FirstName,LastName=x.LastName,Genders=x.Genders,ActivityType=x.ActivityType,GoalWeight=x.GoalWeight,Height=x.Height}).ToList();
        //}
        //public static void Create(User user)
        //{

        //}
    }
}
