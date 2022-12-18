using AutoMapper;
using StudentPortal.Models.Courses;
using StudentPortal.Models.EntityModels;
using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Models.Student;

namespace StudentPortal.AutoMapperProfile
{
    public class StudentportalAMProfile : Profile
    {
        public StudentportalAMProfile()
        {
            CreateMap<StudentVM, StudentEModel>();
            CreateMap<CourseVM, Course_E_model>();
        }

    }
}
