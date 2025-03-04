using StudentManager.Domain.Entities;
using System.Threading.Tasks;

namespace StudentManager.Application.Interfaces
{
    public interface IEnrollmentRepository
    {
        // Checks if a student is already enrolled in a specific course.
        Task<bool> IsStudentEnrolledAsync(int studentId, int courseId);

        // Adds a new enrollment record.
        Task AddEnrollmentAsync(EnrollmentEntity enrollment);

        // You can add more methods if needed, such as removing an enrollment.
    }
}
// HandCrafted By Rohan Thapa.