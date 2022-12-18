using StudentPortal.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Service.Abstructions.Base
{
    public interface IService<T> where T : class
    {

        public Result Add(T entity);
        public Result Remove(T entity);
        public Result Update (T entity);
        public T GetById(Expression<Func<T, bool>> predicate);

        //public ICollection<T> Get(Expression<Func<T, bool>> predicate = null);
        public ICollection<T> GetAll();

    }
}
