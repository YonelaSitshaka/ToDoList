using ToDo6.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ToDo6.Permissions;

public class ToDo6PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ToDo6Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ToDo6Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ToDo6Resource>(name);
    }
}
