using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIProjct.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<CourseLibrary.API.Entities.Course, Models.CourseDto>();
            CreateMap<Models.CourseForCreationDto, CourseLibrary.API.Entities.Course>();
            CreateMap<Models.CourseForUpdateDto, CourseLibrary.API.Entities.Course>();
        }
    }
}
