using AutoMapper;
using CRUD_operation.DTOs;
using meraproject.DTOs;
using meraproject.Interfaces.RepoInterface;
using meraproject.Interfaces.ServiceInterface;
using meraproject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.Collections;

namespace CRUD_operation.Services
{
    public class StudentService : IStudentServiceInterface
    {
        public readonly IStudentRepoInterface _repo;
        public readonly IMapper _mapper;

        public StudentService(IStudentRepoInterface repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetStudentDto>> Getstudent()
        {
            var students = await _repo.getAllStudentAsync();
            return _mapper.Map<IEnumerable<GetStudentDto>>(students);
        }

      public async  Task<GetStudentDto> GetStudentById(int Id)
        {
            var students = await _repo.getstudentbyidAsync(Id);
            if (students==null)
                {
                return null;
            }           
            return _mapper.Map<GetStudentDto>(students);

        }
        public async Task<GetStudentDto> Createstudent(CreateStudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);

            var students = await _repo.createstudentAsync(student);

            return _mapper.Map<GetStudentDto>(students);
        }
        public async Task<UpdateStudentDto>UpdateStudent(int Id,UpdateStudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);
            var students = await _repo.updatestudentAsync(Id,student);
            return _mapper.Map<UpdateStudentDto>(students);
        }
        public async Task<GetStudentDto>DeleteStudent(int Id)
        {
            var student =await _repo.getstudentbyidAsync(Id);
                if (student==null)
            {
                throw new KeyNotFoundException("student not found ");
            }
                var students=await _repo.deletestudentAsync(Id);
            return _mapper.Map<GetStudentDto>(students);

            
        }



    }
}
