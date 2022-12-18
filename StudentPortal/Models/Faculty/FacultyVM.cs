using StudentPortal.Models.EntityModels.DepartmentAndSubject;

namespace StudentPortal.Models.Faculty
{
    public class FacultyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<DepartmentE_model> departmentE_Models { get; set; }
    }
}
