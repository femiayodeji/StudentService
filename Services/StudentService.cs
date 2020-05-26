using StudentService.Data;
using StudentService.Models;

namespace StudentService.Services
{
    public class StudentService : InMemoryStudentRepo, IStudentService
    {
        public StudentService(StudentContext context) : base(context)
        {
        }
    }
}