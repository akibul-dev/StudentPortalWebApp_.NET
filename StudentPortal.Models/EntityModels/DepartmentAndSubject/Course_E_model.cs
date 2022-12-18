using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Models.EntityModels.DepartmentAndSubject
{
    public class Course_E_model

    {
        public int Id { get; set;}

        public string Name { get; set;}

        public string Code { get; set;}

        public int Credit { get; set;}
        public int DepartmentId { get; set;}
        public DepartmentE_model? Department { get; set;}
        


    }
}
