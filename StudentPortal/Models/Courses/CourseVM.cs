using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models.Courses
{
    public class CourseVM
    {
        public int? Id { get; set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public int Credit { get; set;}
        [Required(ErrorMessage ="This field is Required!!")]
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        //public int FacultyId { get; set; }


        public List<SelectListItem>? Departments { get; set; }


    }
}
