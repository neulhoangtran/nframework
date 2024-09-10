using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFramework.Core.Interfaces;

namespace NFramework.Core.Abstracts
{
        // Abstract class for service implementations, providing basic methods
    public abstract class AbstractService<T> : IService<T>
    {
        protected readonly IRepository<T> _repository;

        protected AbstractService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual T Load(int id) => _repository.Load(id);

        //public virtual IEnumerable<T> GetAll() => _repository.GetAll();

        public virtual void Add(T entity) => _repository.Add(entity);

        public virtual void Update(T entity) => _repository.Update(entity);

        public virtual void Delete(int id) => _repository.Delete(id);
    }

}
