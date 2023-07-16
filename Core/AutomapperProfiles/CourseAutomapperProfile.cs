using AutoMapper;
using Core.Courses.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AutomapperProfiles
{
    public class CourseAutomapperProfile : Profile
    {
        public CourseAutomapperProfile()
        {
            CreateMap<CreateCourseDto, Course>();
        }
    }
}
