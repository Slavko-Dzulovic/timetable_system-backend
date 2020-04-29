using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Modules
{
    public class ModulesRepository : Repository<Module, short>, IModulesRepository
    {
        private readonly TimetableDbContext _dbContext;

        public ModulesRepository(TimetableDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Module> GetModules()
        {
            return _dbContext.Modules.ToList();
        }

        public async Task<List<Module>> GetModulesAsync()
        {
            return await _dbContext.Modules.ToListAsync();
        }
    }
}