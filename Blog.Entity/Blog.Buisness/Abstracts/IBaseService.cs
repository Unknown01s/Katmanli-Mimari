using System;
namespace Blog.Buisness.Abstracts
{
	public interface IBaseService<T> where T : Blog.Entity.Abstracts.Entity,new()
	{
        List<T> GetAll();
        List<T> GetByFilter(Func<T, bool> filter);
        T Get(Func<T, bool> filter);


        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

