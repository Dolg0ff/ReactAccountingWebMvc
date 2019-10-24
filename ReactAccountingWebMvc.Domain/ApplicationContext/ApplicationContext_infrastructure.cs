using System;
using System.IO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReactAccountingWebMvc.Domain.Models;


namespace ReactAccountingWebMvc.Domain
{
    public partial class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public IConfigurationRoot Configuration { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            this.Database.EnsureCreated();
        }

        public ApplicationContext()
        {
        }

        public ApplicationContext CreateTestContext()
        {
            throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String ConnStr = "";
            if (Configuration == null)
            {
#if DEBUG
                ConnStr = "Outside_Local";
#else
				ConnStr = "Outside_Production";
#endif

                Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            }
            else
            {
                ConnStr = "Outside_Test";
            }

            String connectionString = Configuration.GetConnectionString(ConnStr);
            optionsBuilder.UseSqlServer(connectionString);
        }

        //protected override void OnConfiguring_(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-A1BVP07;Database=AccountStorageReact;Trusted_Connection=True;");
        //}
    }
}