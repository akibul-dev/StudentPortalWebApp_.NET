using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StudentPortal.Models.EntityModels;
using StudentPortal.Models.Result;
using StudentPortal.Models.Student;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Service;
using StudentPortal.Service.Abstructions;
using StudentServices;

namespace StudentPortal.Controllers
{
    public class Student : Controller
    {
        IStudentService _studentService;
        IMapper _mapper;
        public Student(IStudentService studentService , IMapper mapper)
        {
           _studentService= studentService;
            _mapper= mapper;
        }

        //Get All Student//
        public IActionResult Index()
        {
            var allStudent = _studentService.GetAll();

            var allStudentvm = new List<StudentListVM>();
            foreach (var student in allStudent)
            {
                var studentVM = new StudentListVM()
                {
                    ID = student.ID,
                    Name = student.Name,
                    Address = student.Address,
                    PhoneNumber = student.PhoneNumber,
                    StudentID = student.StudentID,
                };

                allStudentvm.Add(studentVM);
            }


            return View(allStudentvm);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(StudentVM model)

        {

            if (ModelState.IsValid)
            {



                var student = _mapper.Map<StudentEModel>(model);

                //student.Name = model.Name;
                //student.Address = model.Address;
                //student.PhoneNumber = model.PhoneNumber;
                //student.StudentID = model.StudentID;



                var result = _studentService.Add(student);

                
                    
                

                if (result.ErrorMessages.Any())
                {
                    foreach(var error in result.ErrorMessages)
                    {
                        ModelState.AddModelError("", error);
                    }

                    
                }
                return RedirectToAction("Index");
            }



            return View(model);
        }



       
        //Student Edit
        public IActionResult Edit(int Id)
        {
            var student = _studentService.GetById(c=>c.ID==Id);

            StudentEditVM studentEdit = new StudentEditVM();
            if (student != null)
            {
                studentEdit.ID = student.ID;
                studentEdit.Name = student.Name;
                studentEdit.Address = student.Address;
                studentEdit.PhoneNumber = student.PhoneNumber;
                studentEdit.StudentID = student.StudentID;
            }


            return View(studentEdit);
        }


        [HttpPost]
        public IActionResult Edit(StudentEditVM editedStudent)
        {
            if (ModelState.IsValid)
            {
                var _student = _studentService.GetById(c=>c.ID==editedStudent.ID);

                _student.Name = editedStudent.Name;
                _student.Address = editedStudent.Address;
                _student.PhoneNumber = editedStudent.PhoneNumber;
                _student.StudentID = editedStudent.StudentID;

               _studentService.Update(_student);

            }

            return RedirectToAction("Index");
        }


        public IActionResult Remove(int Id)
        {
            var existingStudent = _studentService.GetById(c=>c.ID==Id);
            
            if (existingStudent != null)
            {
                _studentService.Remove(existingStudent);
               ViewBag.SuccessMessage= "Student Removed Successfully";
                
            }
            return RedirectToAction("Index");
            
            
        }
    }

}
