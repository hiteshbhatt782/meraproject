using CRUD_operation.DTOs;
using meraproject.Data;
using meraproject.DTOs;
using meraproject.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace CRUD_operation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;

        public StuController(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]//get all student in a list
        public IActionResult GetAllStudents()
        {
            var allstudents = dbcontext.Students.ToList();
            return Ok(allstudents);
        }
        [HttpGet("student/{id}")]//get student by id 
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = dbcontext.Students.Find(id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }
        [HttpPost]//create 
        public IActionResult AddStudents(CreateStudentDto createStudentDto)
        {

            var StudentEntity = new Student()
            {
                StudentName = createStudentDto.StudentName,
                course = createStudentDto.course,
                email = createStudentDto.email,
                address = createStudentDto.address
            };


            dbcontext.Students.Add(StudentEntity);
            dbcontext.SaveChanges();

            return Ok(StudentEntity);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, UpdateStudentDto updatestudentdto)
        {
            var student = dbcontext.Students.Find(id);
            if (student is null)
            {
                return NotFound();
            }
            student.StudentName = updatestudentdto.StudentName;
            student.email = updatestudentdto.email;
            student.course = updatestudentdto.course;
            student.address = updatestudentdto.address;
            student.PhoneNumber = updatestudentdto.PhoneNumber;
            dbcontext.SaveChanges();
            return Ok(student);


        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var student = dbcontext.Students.Find(id);
            if (student is null)
            {
                return NotFound();
            }
            dbcontext.Students.Remove(student);
            dbcontext.SaveChanges();
            return Ok();
        }
    }
}
