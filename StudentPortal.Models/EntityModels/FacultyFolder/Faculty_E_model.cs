using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Models.EntityModels.FacultyFolder
{
    public class Faculty_E_model
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        public ICollection<DepartmentE_model> departmentE_Models { get; set; }


    }
}
