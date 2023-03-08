using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpCourse.Data;

/* This is used if database provider does't define
 * IAbpCourseDbSchemaMigrator implementation.
 */
public class NullAbpCourseDbSchemaMigrator : IAbpCourseDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
