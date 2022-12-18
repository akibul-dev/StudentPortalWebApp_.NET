using StudentPortal.Database.Databases;
using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Repositories.Abstructions;
using StudentRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repository
{
    public class CourseRepository : Repository<Course_E_model> , ICourseRepository
    {

        StudentPortalDBcontext _db;
        public CourseRepository(StudentPortalDBcontext db) : base(db)
        {
            _db= db;
        }

        
       
    }
}
