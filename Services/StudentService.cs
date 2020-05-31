using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Student> FindStudents(string keyword)
        {
            return GetAllStudent().Where(x => 
                x.FirstName.Contains(keyword) || 
                x.LastName.Contains(keyword) || 
                x.MatricNumber.Contains(keyword) || 
                x.Year.ToString().Contains(keyword) ||
                x.Program.Contains(keyword) ||
                x.EntryDate.ToString().Contains(keyword)
            );
        }
    }
}