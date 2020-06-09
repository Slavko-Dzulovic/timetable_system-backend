using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters
{
	public class SemestersRepository : Repository<Semester, short>, ISemestersRepository
	{
		private readonly TimetableDbContext _dbContext;
		public SemestersRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
		
		public async Task<bool> CheckIfSemesterExistsAsync(short id)
		{
			return await _dbContext.Semesters.AnyAsync(s => s.Id == id);
		}

		public bool CheckIfSemesterExists(short id)
		{
			return _dbContext.Semesters.Any(s => s.Id == id);
		}

        public List<Semester> GetSemesters()
        {
            return _dbContext.Semesters.ToList();
        }

        public Semester GetSemesterById(short id)
        {
            return _dbContext.Semesters.FirstOrDefault(s => s.Id == id);
        }
        
        public async Task<List<Semester>> GetSemestersAsync()
        {
            return await _dbContext.Semesters.ToListAsync();
        }
    }
}