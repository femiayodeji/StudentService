using System.Collections.Generic;
using StudentService.Models;

namespace StudentService.Data
{
    public interface IStudentRepo
    {
        void CreateStudent(Student student);
        IEnumerable<Student> GetAllStudent();
        Student GetStudentById();
    }
}