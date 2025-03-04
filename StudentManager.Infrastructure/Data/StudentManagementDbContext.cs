using Microsoft.EntityFrameworkCore;
using StudentManager.Domain.Entities;

namespace StudentManager.Infrastructure.Data
{
    public class StudentManagementDbContext : DbContext
    {
        public StudentManagementDbContext(DbContextOptions<StudentManagementDbContext> options)
            : base(options)
        { }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<EnrollmentEntity> Enrollments { get; set; }
        public DbSet<GradesEntity> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary keys and relationships
            modelBuilder.Entity<StudentEntity>()
                .HasKey(s => s.StudentId);
            modelBuilder.Entity<CourseEntity>()
                .HasKey(c => c.CourseId);
            modelBuilder.Entity<EnrollmentEntity>()
                .HasKey(e => e.EnrollmentId);
            modelBuilder.Entity<GradesEntity>()
                .HasKey(g => g.GradeId);

            // Unique constraints (e.g., Email and CourseCode)
            modelBuilder.Entity<StudentEntity>()
                .HasIndex(s => s.Email)
                .IsUnique();
            modelBuilder.Entity<CourseEntity>()
                .HasIndex(c => c.CourseCode)
                .IsUnique();

            // Composite unique constraint to prevent duplicate enrollments
            modelBuilder.Entity<EnrollmentEntity>()
                .HasIndex(e => new { e.StudentId, e.CourseId })
                .IsUnique();

            // Setup relationships
            modelBuilder.Entity<EnrollmentEntity>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<EnrollmentEntity>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<GradesEntity>()
                .HasOne(g => g.Student)
                .WithMany()
                .HasForeignKey(g => g.StudentId);

            modelBuilder.Entity<GradesEntity>()
                .HasOne(g => g.Course)
                .WithMany()
                .HasForeignKey(g => g.CourseId);

            // Check constraint for GradeLetter and resolving the error on here as HasCheckConstraint was discontinued.
            /*modelBuilder.Entity<GradesEntity>()
                .HasCheckConstraint("CK_Grades_GradeLetter", "GradeLetter IN ('A', 'B', 'C', 'D', 'F')");*/

            modelBuilder.Entity<GradesEntity>()
        .HasAnnotation("SqlServer:CheckConstraint", "CK_Grades_GradeLetter CHECK (GradeLetter IN ('A', 'B', 'C', 'D', 'F'))");


            /*modelBuilder.Entity<GradesEntity>()
                .Property(g => g.GradeLetter)
                .HasConversion<char>()
                .HasMaxLength(1)
                .IsRequired();*/

            base.OnModelCreating(modelBuilder);
        }
    }
}
// HandCrafted By Rohan Thapa.