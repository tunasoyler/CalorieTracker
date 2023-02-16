using DAL.Repostories;
using Entities.Concrete;
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
        public List<ActivityType> ActivityTypeList()
        {
            return GetAll().Select(x => new ActivityType { Name = x.Name, ActivityMultiplier=x.ActivityMultiplier }).ToList();
        }
    }
}
