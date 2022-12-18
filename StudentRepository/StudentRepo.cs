using StudentPortal.Database.Databases;
using StudentPortal.Models.EntityModels;
using StudentPortal.Repositories.Abstructions;
using StudentRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repository
{
    public class StudentRepo : Repository<StudentEModel>, IStudentRepository
    {
        
           StudentPortalDBcontext _DB;
        public StudentRepo(StudentPortalDBcontext db) : base(db)
        {
            _DB = db;
        }

            //public bool Create(StudentEModel student)
            //{
            //    _DB.Student.Add(student);
            //    return _DB.SaveChanges() > 0;
            //}
            //public bool Update(StudentEModel student)
            //{
            //    _DB.Student.Add(student);
            //    return _DB.SaveChanges() > 0;
            //}

            //public bool Remove(StudentEModel student)
            //{
            //    _DB.Remove(student);
            //    return _DB.SaveChanges() > 0;
            //}

            //public StudentEModel GetById(int Id)
            //{
            //    return _DB.Student.FirstOrDefault(c => c.ID == Id);

            //}
            //public ICollection<StudentEModel> GetAll()
            //{
            //    return _DB.Student.ToList();
            //}

            //public ICollection<StudentEModel> Get(Expression<Func<StudentEModel, bool>> predicate)
            //{
            //    return _DB.Student.Where(predicate).ToList();
            //}






        
    }
}