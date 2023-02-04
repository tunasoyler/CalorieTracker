using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    public class BaseRepostory <T> where T : class
    {
        Context context = new Context();
        public void Ekle(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public T Bul(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Delete(T entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public IQueryable<T> List()
        {
            return context.Set<T>().AsQueryable();
        }
    }
}
