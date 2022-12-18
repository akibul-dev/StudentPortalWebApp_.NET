using StudentPortal.Service.Abstructions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StudentPortal.Models.EntityModels;
using StudentPortal.Models.Result;

namespace StudentPortal.Service.Abstructions
{
    public interface IStudentService
    {
        public Result Add(StudentEModel student);
        public Result Update(StudentEModel student);
         public Result Remove(StudentEModel student);

        public StudentEModel GetById(Expression<Func<StudentEModel , bool>> predicate);
        public ICollection<StudentEModel> GetAll();

        
    }
}
