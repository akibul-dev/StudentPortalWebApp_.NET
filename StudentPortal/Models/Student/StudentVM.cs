using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models.Student
{
    public class StudentVM
    {
        
        [Required]
       public string Name { get; set; }
        [Required]
        public string StudentID { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }



    }
}
