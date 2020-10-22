using Microsoft.EntityFrameworkCore;
using Lab11.Models;

namespace Lab11.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
    }
}
