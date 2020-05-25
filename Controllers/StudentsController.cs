using Microsoft.AspNetCore.Mvc;
using StudentService.Data;

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
    }
}