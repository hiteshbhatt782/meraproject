using CRUD_operation.DTOs;
using meraproject.DTOs;

namespace CRUD_operation.Interfaces.ServiceInterface
{
    public interface ITeacherServiceInterface
    {
        Task<IEnumerable<TeacherDto>> Getteacher();
        Task<TeacherDto> GetTeahcerById(int Id);
        Task<TeacherDto> CreateTeacher(TeacherDto teacherDto);
    }

}
