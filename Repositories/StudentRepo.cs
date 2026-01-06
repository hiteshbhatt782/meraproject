using meraproject.Data;
using meraproject.Interfaces.RepoInterface;
using meraproject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace meraproject.Repositories
{
    public class StudentRepo : IStudentRepoInterface
    {
        private readonly ApplicationDbContext _context;
        public StudentRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>> getAllStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }
        public async Task<Student> getstudentbyidAsync(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);
        }
        public async Task<Student> createstudentAsync(Student category)
        {
            await _context.Students.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<Student> updatestudentAsync(int id, Student category)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);
            if (student == null)
            {
                throw new KeyNotFoundException("student not found");
            }
            _context.Students.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<Student> deletestudentAsync(int id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.StudentId == id);
            if (student == null)
            {
                throw new KeyNotFoundException("student not found");
            }
            student.isActive = false;
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task<Student> getStudentByEmailAsync(String email)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.email == email);
        }
    }
}