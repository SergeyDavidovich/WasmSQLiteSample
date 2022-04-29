using Volo.Abp.Modularity;

namespace WasmSQLiteSample;

[DependsOn(
    typeof(WasmSQLiteSampleApplicationModule),
    typeof(WasmSQLiteSampleDomainTestModule)
    )]
public class WasmSQLiteSampleApplicationTestModule : AbpModule
{

}
