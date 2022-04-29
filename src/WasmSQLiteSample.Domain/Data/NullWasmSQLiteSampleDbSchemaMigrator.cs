using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WasmSQLiteSample.Data;

/* This is used if database provider does't define
 * IWasmSQLiteSampleDbSchemaMigrator implementation.
 */
public class NullWasmSQLiteSampleDbSchemaMigrator : IWasmSQLiteSampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
