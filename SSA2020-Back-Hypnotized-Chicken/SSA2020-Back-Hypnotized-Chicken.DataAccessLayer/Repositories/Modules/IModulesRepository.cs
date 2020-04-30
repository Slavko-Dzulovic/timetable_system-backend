using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Modules
{
    public interface IModulesRepository : IRepository<Data.Entities.Module, short>
    {
        Task<bool> CheckIfModuleExistsAsync(short moduleId);
        bool CheckIfModuleExists(short moduleId);
        List<Module> GetModules();
        Task<List<Module>> GetModulesAsync();
    }
}