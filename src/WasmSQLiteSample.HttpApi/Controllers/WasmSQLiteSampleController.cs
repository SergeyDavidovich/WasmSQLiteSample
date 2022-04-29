using WasmSQLiteSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WasmSQLiteSample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WasmSQLiteSampleController : AbpControllerBase
{
    protected WasmSQLiteSampleController()
    {
        LocalizationResource = typeof(WasmSQLiteSampleResource);
    }
}
