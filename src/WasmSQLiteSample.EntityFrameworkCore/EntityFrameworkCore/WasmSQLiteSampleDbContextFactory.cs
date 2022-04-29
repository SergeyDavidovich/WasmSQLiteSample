using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WasmSQLiteSample.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class WasmSQLiteSampleDbContextFactory : IDesignTimeDbContextFactory<WasmSQLiteSampleDbContext>
{
    public WasmSQLiteSampleDbContext CreateDbContext(string[] args)
    {
        WasmSQLiteSampleEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<WasmSQLiteSampleDbContext>()
            .UseSqlite(configuration.GetConnectionString("Default"));

        return new WasmSQLiteSampleDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WasmSQLiteSample.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
