using System;
using System.Collections.Generic;
using System.Text;
using WasmSQLiteSample.Localization;
using Volo.Abp.Application.Services;

namespace WasmSQLiteSample;

/* Inherit your application services from this class.
 */
public abstract class WasmSQLiteSampleAppService : ApplicationService
{
    protected WasmSQLiteSampleAppService()
    {
        LocalizationResource = typeof(WasmSQLiteSampleResource);
    }
}
