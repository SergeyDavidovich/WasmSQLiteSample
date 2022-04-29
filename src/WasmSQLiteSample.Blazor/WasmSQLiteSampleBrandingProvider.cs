using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace WasmSQLiteSample.Blazor;

[Dependency(ReplaceServices = true)]
public class WasmSQLiteSampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WasmSQLiteSample";
}
