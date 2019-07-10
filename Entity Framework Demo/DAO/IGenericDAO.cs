using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Demo.DAO
{
    public interface IGenericDAO<T> where T : class
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}
