using StudentPortal.Models.EntityModels;
using StudentPortal.Models.Result;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Repositories.Abstructions.Base;
using StudentPortal.Service.Abstructions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentServices.Base
{
    public abstract class Service<T> : IService<T> where T : class
    {

        IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Result Add(T entity)
        {
            var result = new Result();
           bool isSuccess = _repository.Add(entity);
            if (isSuccess)
            {
                result.SuccessMessage = "Add Successfully";
                return result;
            }
            result.ErrorMessages.Add("Could not Add");
            return result;
        }

        //public ICollection<T> Get(Expression<Func<T, bool>> predicate = null)
        //{
        //   return _repository.Get(predicate);

        //}

        public ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetById(predicate);
        }

        public Result Remove(T entity)
        {
            var result = new Result();
            bool isSuccess = _repository.Remove(entity);
            if (isSuccess)
            {
                result.SuccessMessage = "Remove Successfully";
                return result;
            }
            result.ErrorMessages.Add("Could not Remove");
            return result;
        }

        public Result Update(T entity)
        {
            var result = new Result();
            bool isSuccess = _repository.Update(entity);
            if (isSuccess)
            {
                result.SuccessMessage = "Update Successfully";
                return result;
            }
            result.ErrorMessages.Add("Could not Update");
            return result;
        }

        
    }
}
