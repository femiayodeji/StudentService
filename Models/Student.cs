using System;
using System.ComponentModel.DataAnnotations;

namespace StudentService.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MatricNumber { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(100)]
        public string Program { get; set; } 
        public DateTime EntryDate { get; set; }
    }
}