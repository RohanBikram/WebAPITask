using AutoMapper;
using MediatR;
using StudentManager.Application.Students.DTOs;
using StudentManager.Domain.Entities;
using StudentManager.Application.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StudentManager.Application.Students.Queries;

namespace StudentManager.Application.Students.Handlers
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, IEnumerable<StudentDto>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetAllStudentsQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudentDto>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllStudentsWithCoursesAsync();
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }
    }
}
// HandCrafted By Rohan Thapa.