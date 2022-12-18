using StudentPortal.Models.EntityModels;
using StudentPortal.Repositories.Abstructions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Repositories.Abstructions
{
    public interface IStudentRepository : IRepository<StudentEModel>
    {

    }
}
