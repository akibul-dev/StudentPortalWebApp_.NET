using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repositories.Abstructions.Base
{
    public interface IRepository <T> where T : class
    {


        public bool Add(T entity);
        public bool Update(T entity);
        public bool Remove(T entity);
        public T GetById(Expression<Func<T, bool>> predicate);
        //public ICollection<T> Get(Expression<Func<T, bool>> predicate = null);
        public ICollection<T> GetAll();

            


    }
}
