using DAL.Repostories;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ActivityTypeService : BaseRepository<ActivityType>
    {
        public ActivityTypeService(DbContext context) : base(context)
        {
        }
        public List<ActivityTypeViewModel> ActivityTypeList()
        {                        
            List<ActivityTypeViewModel> ActivityTypeVmList = new List<ActivityTypeViewModel>();

            foreach (ActivityType item in GetAll())
            {
                ActivityTypeViewModel activityTypeViewModel = new ActivityTypeViewModel()
                {
                    ActivityTypeName = item.Name,
                    Id = item.Id
                };
                ActivityTypeVmList.Add(activityTypeViewModel);
            }


            return ActivityTypeVmList;
        }
        public ActivityType GetActivityTypeById(int id)
        {
            var currentActivityType = GetById(id);
            return currentActivityType;
        }
    }
}
