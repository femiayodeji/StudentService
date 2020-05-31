using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentService.Data;
using StudentService.Models;

namespace StudentService.Controller
{
    [Route("api/{controller}")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _studentService;

        public StudentsController(IStudentRepo studentService)
        {
            _studentService = studentService;
        }

        //POST api/students
        [HttpPost]
        public ActionResult <Student> CreateStudent(Student student){
            if(student == null){
                return BadRequest();
            }
            _studentService.CreateStudent(student);
            return Ok(student);
            // if there is read student endpoint, 
            // by REST convention I'm suppose to return 201(created response) with the location of the object
            // instead of 200(Ok)
            // return CreatedAtRoute(nameof(GetStudentById), new {Id = student.Id}, student);
        }

        //GET api/students
        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetStudents(){
            var students = _studentService.GetAllStudent();
            return Ok(students);
        }

        //GET api/students/{id}
        [HttpGet("{id}", Name = "GetStudentById")]
        public ActionResult <Student> GetStudentById(int id){
            var student = _studentService.GetStudentById(id);
            if(student != null){
                return Ok(student);
            }
            return NotFound();
        }
    }
}