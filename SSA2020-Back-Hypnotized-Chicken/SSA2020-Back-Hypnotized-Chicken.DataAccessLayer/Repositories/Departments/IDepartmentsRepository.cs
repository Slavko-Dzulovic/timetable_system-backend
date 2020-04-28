using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments
{
    public interface IDepartmentsRepository : IRepository<Data.Entities.Department, short>
    {
        List<Department> GetDepartments();
        Department GetDepartmentById(int id);
        Task<List<Department>> GetDepartmentsAsync();
    }
}