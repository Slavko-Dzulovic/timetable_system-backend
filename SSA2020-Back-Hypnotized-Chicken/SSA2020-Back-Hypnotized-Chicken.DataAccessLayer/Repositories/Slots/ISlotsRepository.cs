using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Models.Subjects;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Slots
{
	public interface ISlotsRepository : IRepository<Slot, long>
	{
		Task<List<SubjectWithIsOptional>> SubjectsBySemesterAndModuleAsync(short semesterId, short moduleId);
		List<Subject> SubjectsBySemesterAndModule(short semesterId, short moduleId);
		Task<bool> CheckIfSlotExistsAsync(long id);
		long GetSlotIdByAllForeignKeys(short subjectId, short moduleId, short semesterId, short lecturerId);
		Slot GetSlotById(long id);
	}
}