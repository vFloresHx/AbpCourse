using AbpCourse.CustomRepositoryInterfaces;
using AbpCourse.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpCourse.EntityFrameworkCore.CustomRepositories
{
    public class PostCustomRepository : EfCoreRepository<AbpCourseDbContext, Post, Guid>, IPostCustomRepository
    {        
        public PostCustomRepository(IDbContextProvider<AbpCourseDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
       
    }
}
