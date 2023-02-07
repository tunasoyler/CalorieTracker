using DAL.Repostories.Interface;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    public class BaseRepository <T> : IBaseRepository<T>  where T : class
    {
        Context context = new Context();
        public IQueryable<T> GetList()
        {
            return context.Set<T>().AsQueryable();
        }
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity); 
            Save();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Update(T entity,int Id)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            Save();


        }

        public void Save()
        {
            context.SaveChanges();
        }

        //public virtual void Add(T entity)
        //{
        //    using (var context = new TContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public virtual void Delete(T entity)
        //{
            
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
            
        //}

        //public virtual T Get(Expression<Func<T, bool>> filter)
        //{
            
        //    return (context.Set<T>().SingleOrDefault(filter), context);
        //}

        //public virtual (List<TEntity>, TContext) GetAll(Expression<Func<TEntity, bool>> filter = null)
        //{
        //    TContext context = new();
        //    return (filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(), context);
        //}

        //public virtual void Update(T entity)
        //{
            
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        Save();
            
        //}
    }
}
