using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WasmSQLiteSample.Data;
using Volo.Abp.DependencyInjection;

namespace WasmSQLiteSample.EntityFrameworkCore;

public class EntityFrameworkCoreWasmSQLiteSampleDbSchemaMigrator
    : IWasmSQLiteSampleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWasmSQLiteSampleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WasmSQLiteSampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WasmSQLiteSampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
