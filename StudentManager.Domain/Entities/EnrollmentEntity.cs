using System;

namespace StudentManager.Domain.Entities
{
    public class EnrollmentEntity
    {
        // Primary Key: EnrollmentId (INT, Auto Increment)
        public int EnrollmentId { get; set; }

        // Foreign Key to StudentEntity
        public int StudentId { get; set; }
        public StudentEntity? Student { get; set; }

        // Foreign Key to CourseEntity
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }

        // EnrollmentDate (DATETIME, Default: Current Date)
        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        // Note: Unique constraint for student and course combination should be configured in DbContext.
        // Using ModelBuilder, relations among the tables were also created.
    }
}
// HandCrafted By Rohan Thapa.