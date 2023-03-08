using System;
using System.Collections.Generic;
using System.Text;
using AbpCourse.Localization;
using Volo.Abp.Application.Services;

namespace AbpCourse;

/* Inherit your application services from this class.
 */
public abstract class AbpCourseAppService : ApplicationService
{
    protected AbpCourseAppService()
    {
        LocalizationResource = typeof(AbpCourseResource);
    }
}
