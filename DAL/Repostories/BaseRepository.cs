using DAL.Repostories.Interface;
using Entities.Concrete;
using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    public class BaseRepository <T> : IBaseRepository<T>  where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {            
            return _dbSet.Find(id);
        }

        //public T GetByName(string name)
        //{
        //    var result = _context.Set<T>() 
        //    return result;
        //}
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        
        //Context context = new Context();        

        //public void Create(T entity)
        //{
        //    context.Set<T>().Add(entity);
        //    Save();
        //}

        //public void Delete(T entity)
        //{
        //    context.Set<T>().Remove(entity); 
        //    Save();
        //}

        //public T GetById(int id)
        //{
        //    return context.Set<T>().Find(id);
        //}

        //public void Update(T entity,int Id)
        //{
        //    var updatedEntity = context.Entry(entity);
        //    updatedEntity.State = EntityState.Modified;
        //    Save();


        //}

        //public void Save()
        //{
        //    context.SaveChanges();
        //}

        //public IQueryable<T> GetAll()
        //{
        //    return context.Set<T>().AsQueryable();
        //}

    }
}
