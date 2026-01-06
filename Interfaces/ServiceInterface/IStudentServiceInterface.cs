using meraproject.DTOs;
using meraproject.Models.Entities;

namespace meraproject.Interfaces.ServiceInterface
{
    public interface IStudentServiceInterface
    {
        Task<IEnumerable<GetStudentDto>> Getstudent();
        Task<GetStudentDto> GetStudentById(int Id);
        Task<GetStudentDto> Createstudent(CreateStudentDto category);


    }
}
