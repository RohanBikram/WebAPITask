using StudentManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentManager.Application.Interfaces
{
    public interface IStudentRepository
    {
        // Retrieves all students along with their enrolled courses.
        Task<IEnumerable<StudentEntity>> GetAllStudentsWithCoursesAsync();

        // Add more methods as needed (e.g., GetStudentByIdAsync, AddStudentAsync, etc.)
    }
}
// HandCrafted By Rohan Thapa.