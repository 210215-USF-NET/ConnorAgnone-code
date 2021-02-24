using System;
using ToHModels;
using ToHBL;
using ToHDL;
using ToHDL.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the config file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            string connectionString = configuration.GetConnectionString("StoreDB");
            DbContextOptions<StoreDBContext> options = new DbContextOptionsBuilder<StoreDBContext>()
            .UseSqlServer(connectionString)
            .Options;

            using var context = new StoreDBContext(options);

            IMenu menu = new HeroMenu(new HeroBL(new HeroRepoDB(context, new HeroMapper())));
            menu.Start();

        }
    }
}
