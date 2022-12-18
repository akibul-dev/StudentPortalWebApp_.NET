using StudentPortal.Models.EntityModels;
using StudentPortal.Repositories.Abstructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repository.CloudRepositoy
{
    public class CloudStudentRepository : IStudentRepository
    {
        public bool Add(StudentEModel entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentEModel> Get(Expression<Func<StudentEModel, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentEModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentEModel GetById(Expression<Func<StudentEModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Remove(StudentEModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(StudentEModel entity)
        {
            throw new NotImplementedException();
        }
    }
}

