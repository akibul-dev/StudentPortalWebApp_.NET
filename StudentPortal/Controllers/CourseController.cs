using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentPortal.Models.Courses;
using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Models.Result;
using StudentPortal.Service;
using StudentPortal.Service.Abstructions;
using StudentRepository;
using StudentServices;

namespace StudentPortal.Controllers
{
    public class CourseController : Controller
    {
        ICourseService _courseService;
        IDepartmentService _departmentService;
        IMapper _mapper;

        public CourseController(ICourseService courseService, IDepartmentService departmentService , IMapper mapper)
        {
            _departmentService= departmentService;
            _courseService = courseService;
            _mapper = mapper;
        }


        // GET: CourseController
        public ActionResult Index()
        {

           var AllCourse =  _courseService.GetAll();

            var  _courses = new List<CourseVM>();

            foreach (var course in AllCourse)
            {
                
                var departmentName = _departmentService.GetById(c=>c.Id == course.DepartmentId);

                CourseVM _courseVM = new CourseVM()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Code = course.Code,
                    Credit = course.Credit,
                    DepartmentName = departmentName.DeptName,

                };

                _courses.Add(_courseVM);
            }
            return View(_courses);
        }
       
        // GET: CourseController/Create
        public ActionResult Create()
        {
            var departments = _departmentService.GetAll();
            var deptlistItem = departments.Select(c => new SelectListItem()
            {
                Text = c.DeptName,
                Value = c.Id.ToString(),
            }).ToList();

            var courseVm = new CourseVM();
            courseVm.Departments = deptlistItem;

            return View(courseVm);   
        }

        // POST: CourseController/Create
        [HttpPost]
        
        public ActionResult Create(CourseVM model)
        {
            if (ModelState.IsValid)
            {
                var courses = _mapper.Map<Course_E_model>(model);

                 _courseService.Add(courses);

                
                    ViewBag.mesg = "Course Created";

                    return RedirectToAction("Index");

            }
            Result result = new Result();

            result.ErrorMessages.Add("Could not Create new Course!!");


            return View(result);
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {


            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            var course = _courseService.GetById(c => c.Id == id);

            if (course!=null)
            {
                  _courseService.Remove(course);


                    return RedirectToAction("index");
               
            }
            

            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
