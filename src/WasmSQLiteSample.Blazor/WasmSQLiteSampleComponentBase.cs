using WasmSQLiteSample.Localization;
using Volo.Abp.AspNetCore.Components;

namespace WasmSQLiteSample.Blazor;

public abstract class WasmSQLiteSampleComponentBase : AbpComponentBase
{
    protected WasmSQLiteSampleComponentBase()
    {
        LocalizationResource = typeof(WasmSQLiteSampleResource);
    }
}
