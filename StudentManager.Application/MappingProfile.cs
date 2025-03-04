using AutoMapper;
using StudentManager.Application.Students.DTOs;
using StudentManager.Domain.Entities;
using System.Linq;

namespace StudentManager.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentEntity, StudentDto>()
                .ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.Enrollments.Select(e => e.Course)));
            CreateMap<CourseEntity, CourseDto>();
        }
    }
}
// HandCrafted By Rohan Thapa.