using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpCourse;

[Dependency(ReplaceServices = true)]
public class AbpCourseBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpCourse";
}
