using Volo.Abp.Modularity;

namespace AbpCourse;

[DependsOn(
    typeof(AbpCourseApplicationModule),
    typeof(AbpCourseDomainTestModule)
    )]
public class AbpCourseApplicationTestModule : AbpModule
{

}
