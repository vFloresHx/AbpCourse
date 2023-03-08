using Volo.Abp.Settings;

namespace AbpCourse.Settings;

public class AbpCourseSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpCourseSettings.MySetting1));
    }
}
