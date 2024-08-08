using Microsoft.EntityFrameworkCore;

namespace DBModels
{
    public class DEPIContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection String
            /*
             Data Source=DESKTOP-8A1PS5P;
            Initial Catalog=Musicana;
            Integrated Security=True;
            Trust Server Certificate=True
             */
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8A1PS5P;Initial Catalog=DBdepi;Integrated Security=True;Trust Server Certificate=True");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}
