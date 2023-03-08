using AbpCourse.CustomRepositoryInterfaces;
using AbpCourse.Dtos;
using AbpCourse.Entities;
using AbpCourse.Interfaces.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AbpCourse
{
    public class PostsAppService : CrudAppService<Post, PostDto, Guid, PagedAndSortedResultRequestDto, UpdateOrCreatePostDto, UpdateOrCreatePostDto>, IPostsAppService
    {
        private readonly IPostCustomRepository _postRepository;

        public PostsAppService(IPostCustomRepository repo) : base(repo)
        {
            _postRepository= repo;
        }

        public async Task<int> AddLike(Guid postId) 
        {
            // Get the Post entity
            var post = await _postRepository.GetAsync(x => x.Id == postId);

            // Increment Like counter
            post.NumberOfLikes += 1;

            // Update the record in the DB
            await _postRepository.UpdateAsync(post);

            // Return the new updated number of likes
            return post.NumberOfLikes;
        }

    }
}
