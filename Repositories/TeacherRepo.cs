using CRUD_operation.Interfaces.RepoInterface;
using CRUD_operation.Models.Entities;
using meraproject.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace CRUD_operation.Repositories
{
    public class TeacherRepo : ITeacherRepoInterface

    {
        private readonly ApplicationDbContext _context;
        public TeacherRepo(ApplicationDbContext context)
        {
            _context = context;
        }
      public async Task<IEnumerable<Teacher>> GetTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }
      public async   Task<Teacher> getteacherbyIdAsync(int Id)
        {
            return await _context.Teachers.FirstOrDefaultAsync(x => x.id == Id);
        }
        public async Task<Teacher> createteacherAsync(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }
       public async Task<Teacher> updateteacherAsync(int Id, Teacher teacher)
        {
            var teachers = await _context.Teachers.FirstOrDefaultAsync(x=>x.id==Id);
            if (teacher == null)
            {
                throw new KeyNotFoundException("teacher not found ");
            }
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }
        public async Task<Teacher> deleteteacherAsync(int Id)
        {
            var teacher = _context.Teachers.FirstOrDefault(x=>x.id==Id);

            if (teacher == null)
            {
                throw new KeyNotFoundException("teacher not found");
            }
            
            teacher.isActive=false; 
            await _context.SaveChangesAsync();
            return teacher;
        }
    }
}
