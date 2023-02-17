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
    public class GenderService : BaseRepository<Genders>
    {
        public GenderService(DbContext context) : base(context)
        {
        }
        public List<Genders> GenderList()
        {
            return GetAll().Select(x => new Genders { Name = x.Name }).ToList();
        }
    }
}
