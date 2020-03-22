using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace SSA2020_Back_Hypnotized_Chicken.Data
{
    public class TimetableDbContextConfiguration
    {
        private const string CASPNetCoreEnvironmentVariable = "ASPNETCORE_ENVIRONMENT";
        private const string CDevelopmentEnvironment = "Development";
        private const string CAppsettingsFileName = "appsettings.json";
        private const string CAppsettingsEnvironmentFileName = "appsettings.{0}.json";
        public IConfiguration Configuration { get; }

        public TimetableDbContextConfiguration(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public TimetableDbContextConfiguration()
        {
            var environmentValue = Environment.GetEnvironmentVariable(CASPNetCoreEnvironmentVariable) ?? CDevelopmentEnvironment;

            var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                                 .AddJsonFile(CAppsettingsFileName, false, true)
                                                                 .AddJsonFile(string.Format(CAppsettingsEnvironmentFileName, environmentValue), true, true);

            Configuration = configurationBuilder.Build();
        }

        public string Host => Configuration.GetSection("DbContextConfiguration")
                                           .GetValue<string>("Host");
        public string Port => Configuration.GetSection("DbContextConfiguration")
                                           .GetValue<string>("Port");
        public string Database => Configuration.GetSection("DbContextConfiguration")
                                               .GetValue<string>("Database");
        public string Username => Configuration.GetSection("DbContextConfiguration")
                                               .GetValue<string>("Username");
        public string Password => Configuration.GetSection("DbContextConfiguration")
                                               .GetValue<string>("Password");
        public bool Pooling => Configuration.GetSection("DbContextConfiguration")
                                            .GetValue<bool>("Pooling");
        public int CommandTimeout => Configuration.GetSection("DbContextConfiguration")
                                                   .GetValue<int>("CommandTimeout");

        public string ConnectionString => $"User ID={Username}; Host={Host}; Port={Port}; Database={Database}; Password={Password}; Pooling={Pooling}; CommandTimeout={CommandTimeout}";
    }
}