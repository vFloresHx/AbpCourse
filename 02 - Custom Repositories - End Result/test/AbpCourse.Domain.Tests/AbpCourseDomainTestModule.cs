using AbpCourse.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpCourse;

[DependsOn(
    typeof(AbpCourseEntityFrameworkCoreTestModule)
    )]
public class AbpCourseDomainTestModule : AbpModule
{

}
