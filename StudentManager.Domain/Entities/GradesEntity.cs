namespace StudentManager.Domain.Entities
{
    public class GradesEntity
    {
        // Primary Key: GradeId (INT, Auto Increment)
        public int GradeId { get; set; }

        // Foreign Key to StudentEntity
        public int StudentId { get; set; }
        public StudentEntity? Student { get; set; }

        // Foreign Key to CourseEntity
        public int CourseId { get; set; }
        public CourseEntity? Course { get; set; }

        // Grade (CHAR(1), Allowed values: A, B, C, D, F)
        public char GradeLetter { get; set; }

        // Note: Ensure grade assignment is only valid if the student is enrolled in the course (business logic).
        // Which is done burining the whole brain of mine.
    }
}
// HandCrafted By Rohan Thapa.