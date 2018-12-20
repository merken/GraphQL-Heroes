using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HeroApp.Data.Model
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HeroesDbContext>
    {
        public HeroesDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextOptions = new DbContextOptionsBuilder()
                .UseSqlServer(configuration.GetConnectionString("HeroesDb"))
                .Options;

            return new HeroesDbContext(dbContextOptions);
        }
    }
}