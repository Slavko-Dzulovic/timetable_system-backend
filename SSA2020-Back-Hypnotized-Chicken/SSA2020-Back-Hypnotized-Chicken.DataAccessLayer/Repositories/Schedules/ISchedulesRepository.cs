using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Schedules
{
	public interface ISchedulesRepository : IRepository<Schedule, short>
	{
		Task<Schedule> AddNewScheduleAsync(Schedule schedule);
		Schedule AddNewSchedule(Schedule schedule);
	}
}