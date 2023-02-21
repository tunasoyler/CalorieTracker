using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class GendersViewModel
    {
        public int Id { get; set; }
        public string GenderName { get; set; }
        public override string ToString()
        {
            return this.GenderName;
        }
    }
}
