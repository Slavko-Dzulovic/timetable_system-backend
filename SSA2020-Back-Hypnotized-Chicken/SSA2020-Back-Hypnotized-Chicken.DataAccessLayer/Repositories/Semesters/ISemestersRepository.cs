using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters
{
	public interface ISemestersRepository : IRepository<Semester, short>
	{
		Task<bool> CheckIfSemesterExistsAsync(short id);
		bool CheckIfSemesterExists(short id);
        List<Semester> GetSemesters();
        Semester GetSemesterById(short id);
        Task<List<Semester>> GetSemestersAsync();
    }
}