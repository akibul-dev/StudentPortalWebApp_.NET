using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models.DepartmentVM;
using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Models.Result;
using StudentPortal.Service.Abstructions;

namespace StudentPortal.Controllers
{
    public class Department : Controller
    {
        IDepartmentService _departmentService;
        public Department(IDepartmentService departmentservice)
        {

               _departmentService= departmentservice;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            DepartmentE_model departmentE_Model = new DepartmentE_model();

            if (ModelState.IsValid)
            {
                departmentE_Model.DeptName = model.DeptName;
                departmentE_Model.DeptCode = model.Deptcode;
                //departmentE_Model.CreatedBye = "Admin";
                //departmentE_Model.DateTime = DateTime.Now;

                var result = new Result();
                 result= _departmentService.Add(departmentE_Model);
                if (result.IsSuccess)
                {

                    Console.WriteLine("Department Added Successfully");

                }
            }




            Console.WriteLine("Errorrrrrrrrrrrrrrrrrrrrrrr");


            return View();
        }






    }
}
