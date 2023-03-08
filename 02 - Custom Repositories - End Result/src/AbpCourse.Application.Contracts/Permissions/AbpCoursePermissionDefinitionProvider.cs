using AbpCourse.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpCourse.Permissions;

public class AbpCoursePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpCoursePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpCoursePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCourseResource>(name);
    }
}
