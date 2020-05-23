using System;

namespace StudentService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatricNumber { get; set; }
        public int Year { get; set; }
        public string Program { get; set; } 
        public DateTime EntryDate { get; set; }
    }
}