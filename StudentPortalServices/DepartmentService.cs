using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Service.Abstructions;
using StudentServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortalServices
{
    public class DepartmentServicen : Service<DepartmentE_model>, IDepartmentService
    {
        IDepartmentRepository _IDeparmentRepository;
        public DepartmentServicen(IDepartmentRepository departmentRepository):base(departmentRepository)

        {
                _IDeparmentRepository= departmentRepository;
        }

    }
}
