using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Schedules
{
	public class SchedulesRepository : Repository<Schedule, short>, ISchedulesRepository
	{
		private readonly TimetableDbContext _dbContext;
		public SchedulesRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}
		
		public async Task<Schedule> AddNewScheduleAsync(Schedule schedule)
		{
			var checkIfAlreadyAddedQuery = await _dbContext.Schedules.AnyAsync(s => s.Id == schedule.Id);
			if (checkIfAlreadyAddedQuery)
			{
				return null;
			}

			await _dbContext.Schedules.AddAsync(schedule);

			return schedule;
		}

		public Schedule AddNewSchedule(Schedule schedule)
		{
			throw new System.NotImplementedException();
		}
	}
}