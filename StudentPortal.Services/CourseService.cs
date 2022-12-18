using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Service.Abstructions;
using StudentServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Service
{
    public class CourseService : Service<Course_E_model>, ICourseService
    {
        ICourseRepository _courseRepositoy;
        public CourseService(ICourseRepository courseRepository) : base(courseRepository)
        {
            _courseRepositoy = courseRepository;

        }



    }
}
