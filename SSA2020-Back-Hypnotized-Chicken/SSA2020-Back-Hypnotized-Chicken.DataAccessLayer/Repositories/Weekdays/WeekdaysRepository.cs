using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Weekdays
{
	public class WeekdaysRepository : Repository<Weekday, short>, IWeekdaysRepository
	{
		private readonly TimetableDbContext _dbContext;

		public WeekdaysRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<bool> CheckIfWeekdayExistsAsync(short id)
		{
			return await _dbContext.Weekdays.AnyAsync(wd => wd.Id == id);
		}

		public async Task<List<Weekday>> GetAllWeekdaysAsync()
		{
			return await _dbContext.Weekdays.ToListAsync();
		}

		public List<Weekday> GetAllWeekdays()
		{
			return _dbContext.Weekdays.ToList();
		}

		public Weekday GetWeekdayById(short id)
		{
			return _dbContext.Weekdays.FirstOrDefault(w => w.Id == id);
		}
	}
}