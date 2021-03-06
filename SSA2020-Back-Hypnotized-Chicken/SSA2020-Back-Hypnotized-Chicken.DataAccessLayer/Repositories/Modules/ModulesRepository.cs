﻿using System.Collections.Generic;
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

        public async Task<bool> CheckIfModuleExistsAsync(short moduleId)
        {
            return await _dbContext.Modules.AnyAsync(m => m.Id == moduleId);
        }

        public bool CheckIfModuleExists(short moduleId)
        {
            return _dbContext.Modules.Any(m => m.Id == moduleId);
        }

        public List<Module> GetModules()
        {
            return _dbContext.Modules.ToList();
        }
        public Module GetModuleById(int id)
        {
            return _dbContext.Modules.FirstOrDefault(m => m.Id == id);
        }
        public async Task<List<Module>> GetModulesAsync()
        {
            return await _dbContext.Modules.ToListAsync();
        }

        public async Task<List<Module>> GetModulesByDepartmentAsync(short departmentId)
        {
            return await _dbContext.Modules.Where(m => m.DepartmentId == departmentId).ToListAsync();
        }

        public List<Module> GetModulesByDepartment(short departmentId)
        {
            return _dbContext.Modules.Where(m => m.DepartmentId == departmentId).ToList();
        }
    }
}