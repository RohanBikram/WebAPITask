using System;
using System.Collections.Generic;

namespace StudentManager.Application.Students.DTOs
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string? FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<CourseDto>? Courses { get; set; }
    }

    public class CourseDto
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
    }
}
// HandCrafted By Rohan Thapa.