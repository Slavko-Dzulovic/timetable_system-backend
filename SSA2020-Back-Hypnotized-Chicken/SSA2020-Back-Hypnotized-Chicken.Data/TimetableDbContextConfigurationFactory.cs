using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SSA2020_Back_Hypnotized_Chicken.Data;

namespace MSystem.Data
{
    public class TimetableDbContextConfigurationFactory : IDesignTimeDbContextFactory<TimetableDbContext>
    {
        public TimetableDbContext CreateDbContext(string[] args)
        {
            var dbContextConfiguration = new TimetableDbContextConfiguration();
            var dbContextBuilder = new DbContextOptionsBuilder<TimetableDbContext>();
            dbContextBuilder.UseNpgsql(dbContextConfiguration.ConnectionString); 
            return new TimetableDbContext(dbContextBuilder.Options);
        }
    }
}