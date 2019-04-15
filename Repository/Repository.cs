using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Repository
{
    public class Repository<T> : IRepository<T>
    {
        public Repository()
        {

        }

        public T Get(int id)
        {
            using (var session = DataBase.OpenSession())
                return session.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            using (var session = DataBase.OpenSession())
                return session.Query<T>().ToList();
        }

        public T Save(T obj)
        {
            using (var session = DataBase.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(obj);
                    transaction.Commit();
                }
                return obj;
            }
        }

        public void Delete(int id)
        {
            var obj = Get(id);

            using (var session = DataBase.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(obj);
                    transaction.Commit();
                }
            }
        }

        public bool Update(T obj)
        {
            using (var session = DataBase.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(obj);
                    try
                    {
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                return true;
            }
        }
    }
}