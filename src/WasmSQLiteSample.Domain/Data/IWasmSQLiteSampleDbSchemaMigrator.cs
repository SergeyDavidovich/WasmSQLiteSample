using System.Threading.Tasks;

namespace WasmSQLiteSample.Data;

public interface IWasmSQLiteSampleDbSchemaMigrator
{
    Task MigrateAsync();
}
