using Application.Context;
using Core.Entity.Base;
using Core.Exceptions;
using Core.Repository.Basic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Repository.Base
{
    public class CrudService<T> : ICrudManager<T>,IDisposable where T : Base_Entity
    {
        public int delete(T entity)
        {
            using (var DefaultDbContext = new DefaultDbContext())
            {
                DefaultDbContext.Set<T>().Remove(entity);
                DefaultDbContext.SaveChanges();
            }
            return 1;
        }

        

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<T> getall()
        {
            IEnumerable<T> list;
            using (var context = new DefaultDbContext())
            {
                list = context.Set<T>().ToList<T>();
            }
            return list;
        }

        public T insert(T entity)
        {
            using (var context = new DefaultDbContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public T update(int id, T entity)
        {
            using (var context = new DefaultDbContext())
            {
                entity.Id = id;
                context.Set<T>().Attach(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public T whereById(int id)
        {
            T e;
            using (var context = new DefaultDbContext())
            {
                try
                {
                    e = context.Set<T>().Where(x => x.Id == id).First();
                }
                catch (Exception exception)
                {
                    throw new SomethingNotFound();
                }
            }
            return e;
        }
    }
}
