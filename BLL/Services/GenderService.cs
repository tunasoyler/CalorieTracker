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
    public class GenderService : BaseRepository<Genders>
    {
        public GenderService(DbContext context) : base(context)
        {
        }
        public List<GendersViewModel> GenderList()
        {                       
            List<GendersViewModel> GendersVmList = new List<GendersViewModel>();

            foreach (Genders item in GetAll())
            {
                GendersViewModel gendersViewModel = new GendersViewModel()
                {
                    GenderName = item.Name,
                    Id = item.Id
                };
                GendersVmList.Add(gendersViewModel);
            }           
            return GendersVmList;
        }
        public Genders GetGenderById(int id)
        {
            var currentGender = GetById(id);
            return currentGender;
        }
        
    }
}
