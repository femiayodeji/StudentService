using System;
using System.Collections.Generic;
using System.Linq;
using StudentService.Models;

namespace StudentService.Data
{
    public class InMemoryStudentRepo : IStudentRepo
    {
        private readonly StudentContext _context;

        public InMemoryStudentRepo(StudentContext context)
        {
            _context = context;
        }
        public void CreateStudent(Student student)
        {
            if(student == null){
                throw new ArgumentNullException(nameof(student));
            }
            _context.Students.Add(student);
            SaveChanges();
        }

        public IEnumerable<Student> GetAllStudent(){
            return _context.Students.ToList();
        }

        private bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}