using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects
{
	public interface ISubjectsRepository : IRepository<Data.Entities.Subject, short>
	{
		Task<bool> CheckIfSubjectExistsAsync(short subjectId);
		bool CheckIfSubjectExists(short subjectId);
		List<Subject> GetSubjects();
		Task<List<Subject>> GetSubjectsAsync();
	}
}