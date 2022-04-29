using WasmSQLiteSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WasmSQLiteSample;

[DependsOn(
    typeof(WasmSQLiteSampleEntityFrameworkCoreTestModule)
    )]
public class WasmSQLiteSampleDomainTestModule : AbpModule
{

}
