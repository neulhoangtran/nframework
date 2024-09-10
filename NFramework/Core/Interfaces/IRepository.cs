using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFramework.Core.Interfaces
{
    // Generic interface for all repositories
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T Load(int id);
        //IEnumerable<T> GetAll();
    }
}
