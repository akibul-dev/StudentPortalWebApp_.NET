using StudentPortal.Models.EntityModels;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Repositories.Abstructions.Base;
using StudentPortal.Service.Abstructions;
using StudentServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalServices
{
    public class StudentService : Service<StudentEModel>, IStudentService
    {

        IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
