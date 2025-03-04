using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using StudentManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StudentManager.Infrastructure.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly StudentManagementDbContext _context;

        public EnrollmentRepository(StudentManagementDbContext context)
        {
            _context = context;
        }

        public async Task<bool> IsStudentEnrolledAsync(int studentId, int courseId)
        {
            // Check for an existing enrollment for the given student and course.
            return await _context.Enrollments
                                 .AnyAsync(e => e.StudentId == studentId && e.CourseId == courseId);
        }

        public async Task AddEnrollmentAsync(EnrollmentEntity enrollment)
        {
            // Add the new enrollment record and save changes.
            await _context.Enrollments.AddAsync(enrollment);
            await _context.SaveChangesAsync();
        }
    }
}
// HandCrafted By Rohan Thapa.