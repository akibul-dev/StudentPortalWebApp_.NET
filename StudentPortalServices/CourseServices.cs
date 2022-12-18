using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Repository;
using StudentPortal.Service.Abstructions;
using StudentServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalServices
{
    public class CourseServices : Service<Course_E_model>, ICourseService
    {
        ICourseRepository _courseRepositoy;
        public CourseServices(ICourseRepository courseRepository) : base(courseRepository)
        {
            _courseRepositoy = courseRepository;

        }



    }
}

