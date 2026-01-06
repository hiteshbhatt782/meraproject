using meraproject.Models.Entities;

namespace meraproject.Interfaces.RepoInterface
{
    public interface IStudentRepoInterface
    {
        Task <IEnumerable<Student>> getAllStudentAsync();
        Task<Student> getstudentbyidAsync(int id);
        Task<Student> createstudentAsync(Student category);
        Task<Student> updatestudentAsync(int id, Student category);
        Task<Student> deletestudentAsync(int id);
        Task<Student> getStudentByEmailAsync(String email);
    }
}
