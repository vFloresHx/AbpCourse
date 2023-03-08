using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace AbpCourse.Entities
{
    public class Post : FullAuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }
        public int NumberOfLikes { get; set; }        
        public string ImageUrl { get; set; }
    }
}
