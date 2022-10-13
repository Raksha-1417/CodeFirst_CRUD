using CodeFirst_CRUD.Models;
using Microsoft.EntityFrameworkCore;
namespace CodeFirst_CRUD.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
