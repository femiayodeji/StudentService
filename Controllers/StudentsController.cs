using Microsoft.AspNetCore.Mvc;
using StudentService.Data;
using StudentService.Models;

namespace StudentService.Controller
{
    [Route("api/{controller}")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repository;

        public StudentsController(IStudentRepo repository)
        {
            _repository = repository;
        }

        //POST api/students
        [HttpPost]
        public ActionResult <Student> CreateStudent(Student student){
            if(student == null){
                return BadRequest();
            }
            _repository.CreateStudent(student);
            _repository.SaveChanges();
            return Ok(student);
            // if there is read student endpoint, 
            // by REST convention I'm suppose to return 201(created response) with the location of the object
            // instead of 200(Ok)
            // return CreatedAtRoute(nameof(GetStudentById), new {Id = student.Id}, student);
        }
    }
}