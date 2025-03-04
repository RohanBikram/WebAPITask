using MediatR;
using StudentManager.Application.Students.DTOs;
using System.Collections.Generic;

namespace StudentManager.Application.Students.Queries
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<StudentDto>>
    {
    }
}
// HandCrafted By Rohan Thapa.