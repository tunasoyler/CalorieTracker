

using DAL;
using DAL.Repostories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : BaseRepository<User>
    {
        Context context = new Context();
        public UserService(DbContext context) : base(context)
        {

        }
        public bool DoesUserExist(User user)
        {
            return context.Users.Any(u =>
                u.Name == user.Name
            );
        }
        public void BMRCalculate(User user)
        {
            if (user.Gender.Name == "Male")
            {
                user.BMR = 66 + (13.7 * user.Weight) + (5 * user.Height) - (6.8 * (DateTime.Now.Year - user.BirthDate.Year));
            }
            else
            {
                user.BMR = 655 + (9.6 * user.Weight) + (1.8 * user.Height) - (4.7 * (DateTime.Now.Year - user.BirthDate.Year));
            }
        }

        public void DailyCalorieLimitCalculate(User user)
        {
            switch (user.Timeline)
            {
                case "6 months":
                    user.DailyCalorieLimit = Math.Abs(user.ActivityType.ActivityMultiplier * user.BMR - (7400 * (user.Weight - user.GoalWeight)) / 180);
                    user.DailyCalorieLimit= Math.Ceiling(user.DailyCalorieLimit / 50) * 50;
                    break;
                case "12 months":
                    user.DailyCalorieLimit = Math.Abs(user.ActivityType.ActivityMultiplier * user.BMR - (7400 * (user.Weight - user.GoalWeight)) / 360);
                    user.DailyCalorieLimit = Math.Ceiling(user.DailyCalorieLimit / 50) * 50;
                    break;
            }

        }
        public List<User> UserList()
        {
            return GetAll().Select(x => new User { Id = x.Id, UserType = x.UserType, Name = x.Name, FirstName = x.FirstName, LastName = x.LastName }).ToList();
        }
        public List<User> UserDetailList()
        {
            return GetAll().Select(x => new User { Gender = x.Gender, Height = x.Height, Weight = x.Weight, ActivityType = x.ActivityType, GoalWeight = x.GoalWeight, BirthDate = x.BirthDate, BMR = x.BMR, CreatedDate = x.CreatedDate, UpdatedDate = x.UpdatedDate, Meals = x.Meals, Password = x.Password, State = x.State }).ToList();
        }
        public void AddUser(User user)
        {
            Add(user);
        }
        public void UpdateUser(User user)
        {
            Update(user);
        }
        public void DeleteUser(User user)
        {
            Delete(user);
        }
        public User GetUserById(int id)
        {
            return GetById(id);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return GetAll();
        }

    }
}
