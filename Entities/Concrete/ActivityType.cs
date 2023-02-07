using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ActivityType : CommonEntity
    {
        public double ActivityMultiplier { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public ActivityType()
        {
            Users = new HashSet<User>();
        }
    }
}
