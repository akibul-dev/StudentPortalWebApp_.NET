using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentPortal.Models.EntityModels;
using StudentPortal.Models.EntityModels.DepartmentAndSubject;
using StudentPortal.Models.EntityModels.FacultyFolder;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Database.Databases
{
    public class StudentPortalDBcontext : DbContext
    {
        public StudentPortalDBcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentEModel> Student { get; set; }
        public DbSet<Course_E_model> Courses { get; set; }
        public DbSet<DepartmentE_model> Departments { get; set; }
        public DbSet<Faculty_E_model> Faculty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);

            //string ConnetionString = "Server =DESKTOP-D6HO4S8; Database= StudentPortal;Integrated Security= true";

            //optionsBuilder.UseSqlServer(ConnetionString);

        }

    }
}
