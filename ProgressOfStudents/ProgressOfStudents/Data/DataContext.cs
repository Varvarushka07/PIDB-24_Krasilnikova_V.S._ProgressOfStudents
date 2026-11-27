using Microsoft.EntityFrameworkCore;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Data
{
    public class DataContext : DbContext
    {
        public DbSet<DeanOffice> DeanOffices { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ProgressOfStudents.Entities.Stream> Streams { get; set; }
        public DbSet<ProgressOfStudents.Entities.Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<DisciplineAssignment> DisciplineAssignments { get; set; }
        public DbSet<AcademicPerformance> AcademicPerformances { get; set; }

        public DataContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DeaneryDB;Username=postgres;Password=postgres");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasOne<DeanOffice>()
                .WithMany()
                .HasForeignKey(d => d.DeanOfficeId);

            modelBuilder.Entity<ProgressOfStudents.Entities.Stream>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(s => s.DepartmentId);

            modelBuilder.Entity<ProgressOfStudents.Entities.Group>()
                .HasOne<ProgressOfStudents.Entities.Stream>()
                .WithMany()
                .HasForeignKey(g => g.StreamId);

            modelBuilder.Entity<Student>()
                .HasOne<ProgressOfStudents.Entities.Group>()
                .WithMany()
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<DisciplineAssignment>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(da => da.TeacherId);

            modelBuilder.Entity<DisciplineAssignment>()
                .HasOne<Discipline>()
                .WithMany()
                .HasForeignKey(da => da.DisciplineId);

            modelBuilder.Entity<DisciplineAssignment>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(da => da.DepartmentId);

            modelBuilder.Entity<AcademicPerformance>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(ap => ap.StudentId);

            modelBuilder.Entity<AcademicPerformance>()
                .HasOne<DisciplineAssignment>()
                .WithMany()
                .HasForeignKey(ap => ap.AssignmentId);
        }
    }
}