using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models.Student
{
    public class StudentListVM
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
       
        public string StudentID { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Address { get; set; }

        public double? Quiz1 { get; set; }
        public double? Quiz2 { get; set; }
        public double? Quiz3 { get; set; }
        public double? QuizAverage { get; set; }
        public double? Mid_Term { get; set; }
        public double? Final { get; set; }

        public double? CGPA { get; set; }



    }
}
