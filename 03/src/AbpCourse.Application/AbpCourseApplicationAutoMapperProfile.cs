using AbpCourse.Dtos;
using AbpCourse.Entities;
using AutoMapper;

namespace AbpCourse;

public class AbpCourseApplicationAutoMapperProfile : Profile
{
    public AbpCourseApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Post, PostDto>();

        CreateMap<UpdateOrCreatePostDto, Post>();
    }
}
