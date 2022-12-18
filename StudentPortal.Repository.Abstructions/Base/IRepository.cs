using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repository.Abstructions.Base
{
    public interface IRepository<T> where T : class
    {

        public bool Add(T entity);

        public bool Update(T entity);

        public bool Remove(T entity);

        public bool GetAll();

        public bool Get();


        public bool GetById();



    }
}
