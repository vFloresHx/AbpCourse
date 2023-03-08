using AbpCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace AbpCourse.CustomRepositoryInterfaces
{
    public interface IPostCustomRepository : IRepository<Post, Guid>
    {

    }
}
