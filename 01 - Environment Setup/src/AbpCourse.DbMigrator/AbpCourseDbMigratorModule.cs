using AbpCourse.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpCourse.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCourseEntityFrameworkCoreModule),
    typeof(AbpCourseApplicationContractsModule)
    )]
public class AbpCourseDbMigratorModule : AbpModule
{

}
