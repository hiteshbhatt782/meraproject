using meraproject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace meraproject.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
           public DbSet<Student> Students { get; set; }
        
    }
}
