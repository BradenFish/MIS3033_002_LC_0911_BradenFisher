using a;
using Microsoft.EntityFrameworkCore;

namespace b
{
    public class StudentDB:DbContext
    {
        public DbSet<Student> StudentsTB1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=stu.db");
        }
    }
}

