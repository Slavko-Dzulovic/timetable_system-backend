using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments
{
	public interface IDepartmentsRepository : IRepository<Department, short>
	{
		Task<bool> CheckIfDepartmentExistsAsync(short id);
		bool CheckIfDepartmentExists(short id);
        List<Department> GetDepartments();
        Department GetDepartmentById(short id);
        Task<List<Department>> GetDepartmentsAsync();
    }
}