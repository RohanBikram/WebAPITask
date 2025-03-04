using MediatR;
using StudentManager.Application.Enrollments.Commands;
using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StudentManager.Application.Enrollments.Handlers
{
    public class EnrollStudentCommandHandler : IRequestHandler<EnrollStudentCommand, bool>
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollStudentCommandHandler(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<bool> Handle(EnrollStudentCommand request, CancellationToken cancellationToken)
        {
            bool alreadyEnrolled = await _enrollmentRepository.IsStudentEnrolledAsync(request.StudentId, request.CourseId);
            if (alreadyEnrolled)
                throw new Exception("Student is already enrolled in this course. Please Choose another subject for the enrollment.");

            var enrollment = new EnrollmentEntity
            {
                StudentId = request.StudentId,
                CourseId = request.CourseId,
                EnrollmentDate = DateTime.Now
            };

            await _enrollmentRepository.AddEnrollmentAsync(enrollment);
            return true;
        }
    }
}
// HandCrafted By Rohan Thapa.