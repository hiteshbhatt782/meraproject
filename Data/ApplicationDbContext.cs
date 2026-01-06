using CRUD_operation.Models.Entities;
using meraproject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace meraproject.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
           public DbSet<Student> Students { get; set; }
            public DbSet<Teacher>Teachers { get; set; }
        
    }
}
