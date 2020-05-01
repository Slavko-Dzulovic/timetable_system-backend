﻿using System.Linq;
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

		public async Task<bool> CheckIfScheduleExistsAsync(short id)
		{
			return await _dbContext.Schedules.AnyAsync(sch => sch.Id == id);
		}

		public bool CheckIfScheduleExists(short id)
		{
			return _dbContext.Schedules.Any(sch => sch.Id == id);
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
			var checkIfAlreadyAddedQuery = _dbContext.Schedules.Any(s => s.Id == schedule.Id);
			if (checkIfAlreadyAddedQuery)
			{
				return null;
			}

			_dbContext.Schedules.Add(schedule);

			return schedule;
		}

		public async Task<Schedule> EditScheduleAsync(short id, string name)
		{
			var schedule = await _dbContext.Schedules.FirstOrDefaultAsync(sch => sch.Id == id);
			if (schedule == null)
			{
				return null;
			}

			schedule.Name = name;

			return await _dbContext.SaveChangesAsync() > 0 ? schedule : null;
		}

		public Schedule EditSchedule(short id, string name)
		{
			var schedule = _dbContext.Schedules.FirstOrDefault(sch => sch.Id == id);
			if (schedule == null)
			{
				return null;
			}

			schedule.Name = name;

			return _dbContext.SaveChanges() > 0 ? schedule : null;
		}
	}
}