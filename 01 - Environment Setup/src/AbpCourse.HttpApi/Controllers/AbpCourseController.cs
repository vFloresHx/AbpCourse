using AbpCourse.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpCourse.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpCourseController : AbpControllerBase
{
    protected AbpCourseController()
    {
        LocalizationResource = typeof(AbpCourseResource);
    }
}
