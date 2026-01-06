using CRUD_operation.Services;
using meraproject.DTOs;
using meraproject.Interfaces.ServiceInterface;
using meraproject.Models.Entities;
using meraproject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase 
    { 
        private readonly IStudentServiceInterface _service;

        public StudentsController(IStudentServiceInterface service)
        {
            _service = service;
        }
        [HttpGet("GetStudent")]
        public async Task<IActionResult>GetStudents()
        {
            var student = await _service.Getstudent();
            return Ok(student);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _service.GetStudentById(id);
            
                if (student == null) { 
                    return NotFound();
            }
            return Ok(student);
        }   

        [HttpPost("createstudent")]
        public async Task<IActionResult>CreateStudents(CreateStudentDto studentDto)
        {
         var student=   await _service.Createstudent(studentDto);
            return Ok(new {message="services created",data=student});
        }
    }
}
