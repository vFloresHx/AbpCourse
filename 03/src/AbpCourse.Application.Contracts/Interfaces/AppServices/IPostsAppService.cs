using AbpCourse.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AbpCourse.Interfaces.AppServices
{
    public interface IPostsAppService : ICrudAppService<PostDto, Guid, PagedAndSortedResultRequestDto, UpdateOrCreatePostDto, UpdateOrCreatePostDto>
    {        
    }
}
