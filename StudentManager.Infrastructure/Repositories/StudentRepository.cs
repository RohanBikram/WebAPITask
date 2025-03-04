using StudentManager.Application.Interfaces;
using StudentManager.Domain.Entities;
using StudentManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManager.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentManagementDbContext _context;

        public StudentRepository(StudentManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentEntity>> GetAllStudentsWithCoursesAsync()
        {
            // Use EF Core to include enrollments and then the related courses.
            return await _context.Students
                                 .Include(s => s.Enrollments)
                                    .ThenInclude(e => e.Course)
                                 .ToListAsync();
        }
    }
}
// HandCrafted By Rohan Thapa.