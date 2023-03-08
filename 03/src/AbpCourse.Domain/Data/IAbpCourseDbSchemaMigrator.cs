using System.Threading.Tasks;

namespace AbpCourse.Data;

public interface IAbpCourseDbSchemaMigrator
{
    Task MigrateAsync();
}
