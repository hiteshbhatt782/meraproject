using AutoMapper;
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



    }
}
