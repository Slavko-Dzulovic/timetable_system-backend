using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Slots
{
	public class SlotsRepository : Repository<Slot, long>, ISlotsRepository
	{
		private readonly TimetableDbContext _dbContext;
		public SlotsRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<Subject>> SubjectsBySemesterAndModuleAsync(short semesterId, short moduleId)
		{
			var queryResult = await _dbContext.Slots
				.Include(sub => sub.Subject)
				.Include(mod => mod.Module)
				.Include(sem => sem.Semester)
				.Where(s => s.SemesterId == semesterId && s.ModuleId == moduleId)
				.Select(slot => slot.Subject)
				.Distinct()
				.ToListAsync();
			
			return queryResult;
		}

		public List<Subject> SubjectsBySemesterAndModule(short semesterId, short moduleId)
		{
			var queryResult = _dbContext.Slots
				.Include(sub => sub.Subject)
				.Include(mod => mod.Module)
				.Include(sem => sem.Semester)
				.Where(s => s.SemesterId == semesterId && s.ModuleId == moduleId)
				.Select(slot => slot.Subject)
				.Distinct()
				.ToList();

			return queryResult;
		}
		public async Task<bool> CheckIfSlotExistsAsync(long id)
		{
			return await _dbContext.Slots.AnyAsync(s => s.Id == id);
		}

		public long GetSlotIdByAllForeignKeys(short subjectId, short moduleId, short semesterId, short lecturerId)
		{
			var slotId = _dbContext.Slots
				.Include(sub => sub.Subject)
				.Include(mod => mod.Module)
				.Include(sem => sem.Semester)
				.Include(lec => lec.Lecturer)
				.Where(s => s.SubjectId == subjectId && s.ModuleId == moduleId && s.SemesterId == semesterId && s.LecturerId == lecturerId)
				.Select(slot => slot.Id)
				.Single();

			return slotId;
		}

		public Slot GetSlotById(long id)
		{
			return _dbContext.Slots.FirstOrDefault(s => s.Id == id);
		}
	}
}