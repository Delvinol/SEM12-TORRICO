using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APISemana11A.Models
{
    public class InvoiceContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; Database=APISemana12B; Integrated Security=True;Trust Server Certificate=True ");
        }
    }
}
