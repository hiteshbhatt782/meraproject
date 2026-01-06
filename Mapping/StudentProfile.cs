using AutoMapper;
using meraproject.DTOs;
using meraproject.Models.Entities;
namespace CRUD_operation.Mapping
{
    public class StudentProfile : Profile 
    {
        public StudentProfile() 
        {
            CreateMap<GetStudentDto, Student>();
        }
    }
}
