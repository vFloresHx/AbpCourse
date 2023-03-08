using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpCourse.Dtos
{
    public class PostDto : EntityDto<Guid>
    {
        public string Description { get; set; }
        public int NumberOfLikes { get; set; }
        public string ImageUrl { get; set; }
    }
}
