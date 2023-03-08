using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpCourse.Data;
using Volo.Abp.DependencyInjection;

namespace AbpCourse.EntityFrameworkCore;

public class EntityFrameworkCoreAbpCourseDbSchemaMigrator
    : IAbpCourseDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpCourseDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpCourseDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpCourseDbContext>()
            .Database
            .MigrateAsync();
    }
}
