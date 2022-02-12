using System.Collections.Generic;

namespace Core.Repository.Basic
{
    public interface ICrudManager<T> where T : class
    {
        IEnumerable<T> getall();
        T insert(T entity);
        T update(int id, T entity);
        T whereById(int id);
        int delete(T entity);
    }
}
