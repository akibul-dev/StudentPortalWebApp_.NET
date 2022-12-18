using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Models.Result
{
    public class Result
    {


        public Result()
        {
            ErrorMessages = new List<string>();
            
        }
        public bool IsSuccess { get; set; }

        public ICollection<string> ErrorMessages { get; set; }

        public string SuccessMessage { get; set; }

    }
}
