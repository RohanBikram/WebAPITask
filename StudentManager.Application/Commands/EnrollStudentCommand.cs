using MediatR;

namespace StudentManager.Application.Enrollments.Commands
{
    public class EnrollStudentCommand : IRequest<bool>
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
// HandCrafted By Rohan Thapa.