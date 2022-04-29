using Volo.Abp.Settings;

namespace WasmSQLiteSample.Settings;

public class WasmSQLiteSampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WasmSQLiteSampleSettings.MySetting1));
    }
}
