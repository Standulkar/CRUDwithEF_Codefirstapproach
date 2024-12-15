using Microsoft.EntityFrameworkCore;

namespace CRUDwithEF_Codefirstapproach.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
