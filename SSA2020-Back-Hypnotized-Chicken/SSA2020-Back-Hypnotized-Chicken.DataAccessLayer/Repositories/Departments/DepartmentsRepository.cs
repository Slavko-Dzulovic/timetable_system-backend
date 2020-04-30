using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments
{
	public class DepartmentsRepository : Repository<Department, short>, IDepartmentsRepository
	{
		private readonly TimetableDbContext _dbContext;
		public DepartmentsRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
		
		public async Task<bool> CheckIfDepartmentExistsAsync(short id)
		{
			return await _dbContext.Departments.AnyAsync(d => d.Id == id);
		}

		public bool CheckIfDepartmentExists(short id)
		{
			return _dbContext.Departments.Any(d => d.Id == id);
		}

        public List<Department> GetDepartments()
        {
            return _dbContext.Departments.ToList();
        }
        public Department GetDepartmentById(int id)
        {
            return _dbContext.Departments.FirstOrDefault(d => d.Id == id);
        }
        public async Task<List<Department>> GetDepartmentsAsync()
        {
            return await _dbContext.Departments.ToListAsync();
        }
    }
}