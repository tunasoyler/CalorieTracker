using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class ActivityTypeViewModel
    {
        public int Id { get; set; }
        public string ActivityTypeName { get; set; }
        public override string ToString()
        {
            return this.ActivityTypeName;
        }
    }
}
