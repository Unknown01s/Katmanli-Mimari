using System;
using Blog.DataAccses.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccses.Concretes.EntityFramework.Concretes
{
    public class BaseRepository<T, TContext> : IBaseRepository<T> where T : Blog.Entity.Abstracts.Entity, new()
        where TContext : DbContext,new()
    {
        public void Delete(T entity)
        {
        using(TContext context=new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Func<T, bool> filter)
        {
     using(TContext context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll()
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetByFilter(Func<T, bool> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (TContext context = new TContext())
            {

                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
          using(TContext context=new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

