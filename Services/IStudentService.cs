using System.Collections.Generic;
using StudentService.Data;
using StudentService.Models;

namespace StudentService.Services
{
    public interface IStudentService : IStudentRepo 
    {
        IEnumerable<Student> FindStudents(string keyword);
    }
}