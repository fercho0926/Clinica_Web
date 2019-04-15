using System.Collections.Generic;
using Entities;

namespace Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Save(T obj);
        void Delete(int id);
        bool Update(T obj);

    }
}
