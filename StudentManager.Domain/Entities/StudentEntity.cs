using System;
using System.Collections.Generic;

namespace StudentManager.Domain.Entities
{
    public class StudentEntity
    {
        // Primary Key: StudentId (INT, Auto Increment)
        public int StudentId { get; set; }

        // FullName (VARCHAR)
        public string? FullName { get; set; }

        // DateOfBirth (DATE)
        public DateTime DateOfBirth { get; set; }

        // Email (VARCHAR, Unique)
        public string? Email { get; set; }

        // PhoneNumber (VARCHAR)
        public string? PhoneNumber { get; set; }

        // RegistrationDate (DATETIME, Default: Current Date)
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Navigation property for enrollments
        public ICollection<EnrollmentEntity> Enrollments { get; set; } = new List<EnrollmentEntity>();
    }
}
// HandCrafted By Rohan Thapa.