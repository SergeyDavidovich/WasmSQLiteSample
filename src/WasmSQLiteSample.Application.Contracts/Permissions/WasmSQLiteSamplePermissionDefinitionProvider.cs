using WasmSQLiteSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WasmSQLiteSample.Permissions;

public class WasmSQLiteSamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WasmSQLiteSamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WasmSQLiteSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WasmSQLiteSampleResource>(name);
    }
}
