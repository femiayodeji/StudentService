using StudentService.Data;
using StudentService.Models;

namespace StudentService.Services
{
    public class StudentService : InMemoryStudentRepo, IStudentService
    {
        private readonly StudentContext _context;
        public StudentService(StudentContext context) : base(context)
        {
            _context = context;
        }
    }
}