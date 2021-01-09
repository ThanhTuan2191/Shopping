using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Shopping.Data.EF
{
    class ShoppingOnlineDbContextFactory : IDesignTimeDbContextFactory<ShoppingDbContext>
    {
        public ShoppingDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("ShoppingOnlineDb");
            var optionsBuilder = new DbContextOptionsBuilder<ShoppingDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new ShoppingDbContext(optionsBuilder.Options);
        }
    }
}
