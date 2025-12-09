using meraproject.DTOs;
using meraproject.Models.Entities;

namespace meraproject.Interfaces.ServiceInterface
{
    public interface IStudentServiceInterface
    {
        Task<IEnumerable<GetStudentDto>> getstudent();
        Task<GetStudentDto> getStudentById(int Id);
        Task<CreateStudentDto> createstudent(GetStudentDto category);


    }
}
