using StudentService.Models;

namespace StudentService.Data
{
    public interface IStudentRepo
    {
        bool SaveChanges();
         void CreateStudent(Student student);
    }
}