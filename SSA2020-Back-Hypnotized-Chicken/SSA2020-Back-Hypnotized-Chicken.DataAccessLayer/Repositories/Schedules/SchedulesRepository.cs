﻿using System.Collections.Generic;
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

		public async Task<bool> SetInactiveAsync(short id)
		{
			var schedule = await _dbContext.Schedules.FirstOrDefaultAsync(sch => sch.Id == id &&
			                                                                     sch.IsActive);
			if (schedule == null)
			{
				return false;
			}

			schedule.IsActive = false;
			_dbContext.Schedules.Update(schedule);

			return true;
		}

		public bool SetInactive(short id)
		{
			var schedule = _dbContext.Schedules.FirstOrDefault(sch => sch.Id == id &&
			                                                          sch.IsActive);
			if (schedule == null)
			{
				return false;
			}

			schedule.IsActive = false;
			_dbContext.Schedules.Update(schedule);

			return true;
		}

		public async Task<List<Schedule>> GetActiveSchedulesBySemesterAsync(short semesterId)
		{
			var query = await _dbContext.Schedules.Where(s => s.SemesterId == semesterId && 
			                                                  s.IsActive).ToListAsync();
			return query;
		}

		public List<Schedule> GetActiveSchedulesBySemester(short semesterId)
		{
			var query = _dbContext.Schedules.Where(s => s.SemesterId == semesterId && 
			                                            s.IsActive).ToList();
			return query;
		}

		public async Task<List<Schedule>> GetActiveSchedulesByDepartmentAsync(short departmentId)
		{
			var query = await _dbContext.Schedules.Where(s => s.DepartmentId == departmentId && 
			                                                  s.IsActive).ToListAsync();
			return query;
		}

		public List<Schedule> GetActiveSchedulesByDepartment(short departmentId)
		{
			var query = _dbContext.Schedules.Where(s => s.DepartmentId == departmentId &&
			                                                  s.IsActive).ToList();
			return query;
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