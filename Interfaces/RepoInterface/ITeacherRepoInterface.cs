using CRUD_operation.Models.Entities;

namespace CRUD_operation.Interfaces.RepoInterface
{
    public interface ITeacherRepoInterface
    {
        Task<IEnumerable<Teacher>>GetTeachersAsync();
        Task<Teacher> getteacherbyIdAsync(int Id);
        Task<Teacher>createteacherAsync(Teacher teacher);
        Task<Teacher>updateteacherAsync(int Id,Teacher teacher);
        Task<Teacher> deleteteacherAsync(int Id);
    }
}
