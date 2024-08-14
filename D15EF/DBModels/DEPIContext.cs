using Microsoft.EntityFrameworkCore;

namespace DBModels
{
    public class DEPIContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<InstCourse> InstCourses { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }

        #region Relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Department Manager Relation
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany(i => i.ManagedDepts);

            //-----------------------------------------------------------------

            //Instructor and Course Relation
            modelBuilder.Entity<InstCourse>()
                .HasKey(ic => new { ic.Ins_Id, ic.Crs_Id }); // Define composite primary key

            modelBuilder.Entity<InstCourse>()
                .HasOne(ic => ic.Inst) // Define relationship with Instructor
                .WithMany(i => i.InstCourses) // Specify the collection
                .HasForeignKey(ic => ic.Ins_Id); // Foreign key for Instructor

            modelBuilder.Entity<InstCourse>()
                .HasOne(ic => ic.Crs) // Define relationship with Course
                .WithMany(c => c.CrsInstructors) // Specify the collection
                .HasForeignKey(ic => ic.Crs_Id); // Foreign key for Course

            //-----------------------------------------------------------------

            //Student and Course Relation
            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.Stud_Id, sc.Crs_Id });

            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Stud)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.Stud_Id);

            modelBuilder.Entity<StudCourse>()
                .HasOne(sc => sc.Crs)
                .WithMany(c => c.CrsStudents)
                .HasForeignKey(sc => sc.Crs_Id);

            //-----------------------------------------------------------------

        }
        #endregion

        #region Connection
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
        #endregion
    }
}
