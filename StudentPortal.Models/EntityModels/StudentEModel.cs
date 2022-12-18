using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Models.EntityModels
{
    public class StudentEModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string StudentID { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }


        public double? Quiz1 { get; set; }
        public double? Quiz2 { get; set; }
        public double? Quiz3 { get; set;}
        public double? QuizAverage { get; set; }
        public double? Mid_Term { get; set; }
        public double? Final{ get; set; }
        public double? CGPA { get; set; }

    }
}
