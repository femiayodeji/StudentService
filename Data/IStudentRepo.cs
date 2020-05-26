using StudentService.Models;

namespace StudentService.Data
{
    public interface IStudentRepo
    {
        void CreateStudent(Student student);
    }
}