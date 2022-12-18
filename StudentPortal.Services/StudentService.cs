using StudentRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using StudentPortal.Models.Result;
using StudentPortal.Models.EntityModels;
using System.Diagnostics.CodeAnalysis;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Database.Databases;
using StudentPortal.Service.Abstructions;
using StudentPortal.Repository;
using StudentServices.Base;

namespace StudentPortal.Service
{
    public class StudentService : Service<StudentEModel>, IStudentService

    {
        IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }




        //public Result Add(StudentEModel student)
        //{
        //    Result result = new Result();

        //    var existingStudent = _studentRepository.Get(c => c.StudentID == student.StudentID);

        //    if (existingStudent.Any())
        //    {
        //        result.IsSuccess = false;
        //        result.ErrorMessages.Add("Student already exist with same StudenID");
        //    }

        //    if (result.ErrorMessages.Any())
        //    {
        //        return result;
        //    }

        //    var isSuccess = _studentRepository.Add(student);

        //    if (isSuccess)
        //    {
        //        result.IsSuccess = true;
        //        return result;
        //    }
        //    result.ErrorMessages.Add("Could not create Student");


        //    return result;


        //}

        //public Result Update(StudentEModel student)
        //{
        //    Result result = new Result();
        //    var isSuccess = _studentRepository.Update(student);
        //    if (isSuccess)
        //    {
        //        result.IsSuccess = true;
        //    }
        //    result.ErrorMessages.Add("Could not update student.");

        //    return result;
        //}

        //public Result Remove(StudentEModel student)
        //{
        //    Result result = new Result();
        //    var isSuccess = _studentRepository.Remove(student);
        //    if (isSuccess)
        //    {
        //        result.IsSuccess = true;
        //    }
        //    result.ErrorMessages.Add("Could NOt add student");

        //    return result;

        //}

        //public ICollection<StudentEModel> GetAll()
        //{

        //   return _studentRepository.GetAll();


        //}
        //public StudentEModel GetByID(int Id)
        //{
        //    return _studentRepository.GetById(c => c.ID == Id );

        //}

    }
}
