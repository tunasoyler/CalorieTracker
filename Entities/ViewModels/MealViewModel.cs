using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class MealViewModel
    {
        public int Id { get; set; }
        public List<MealDetailsViewModel> MealDetailsViewModel { get; set; }
        public string MealType { get; set; }
        //date gerekli mi??
        public DateTime? Date { get; set; }

        public MealViewModel()
        {
            MealDetailsViewModel= new List<MealDetailsViewModel>();
        }

    }
}
