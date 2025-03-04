using System.Collections.Generic;

namespace StudentManager.Domain.Entities
{
    public class CourseEntity
    {
        // Primary Key: CourseId (INT, Auto Increment)
        public int CourseId { get; set; }

        // CourseName (VARCHAR)
        public string? CourseName { get; set; }

        // CourseCode (VARCHAR, Unique)
        public string? CourseCode { get; set; }

        // CreditHours (INT, Must be between 1 and 5)
        public int CreditHours { get; set; }

        // Navigation property for enrollments
        public ICollection<EnrollmentEntity> Enrollments { get; set; } = new List<EnrollmentEntity>();
    }
}
// HandCrafted By Rohan Thapa.