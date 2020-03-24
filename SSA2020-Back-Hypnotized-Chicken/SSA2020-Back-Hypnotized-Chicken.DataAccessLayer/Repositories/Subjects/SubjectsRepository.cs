using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects
{
	public class SubjectsRepository : Repository<Subject, short>, ISubjectsRepository
	{
		private readonly TimetableDbContext _dbContext;

		public SubjectsRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
		
		public List<Subject> GetSubjects()
		{
			return _dbContext.Subjects.ToList();
		}

		public async Task<List<Subject>> GetSubjectsAsync()
		{
			return await _dbContext.Subjects.ToListAsync();
		}
	}
}