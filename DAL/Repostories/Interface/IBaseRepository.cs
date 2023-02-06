using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories.Interface
{
    public interface IBaseRepository <T> where T : class
    {
        T GetById(int Id);
        void Create(T entity);
        void Update(T entity,int Id);
        void Delete(T entity);
        void Save();
    }
}
