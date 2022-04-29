using WasmSQLiteSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WasmSQLiteSample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WasmSQLiteSampleEntityFrameworkCoreModule),
    typeof(WasmSQLiteSampleApplicationContractsModule)
    )]
public class WasmSQLiteSampleDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
