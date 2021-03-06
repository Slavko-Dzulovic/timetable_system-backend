﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Schedules
{
	public interface ISchedulesRepository : IRepository<Schedule, short>
	{
		Task<bool> CheckIfScheduleExistsAsync(short id);
		bool CheckIfScheduleExists(short id);
		Task<Schedule> EditScheduleAsync(short id, string name, bool isActive);
		Schedule EditSchedule(short id, string name, bool isActive);
		Task<Schedule> AddNewScheduleAsync(Schedule schedule);
		Schedule AddNewSchedule(Schedule schedule);
		Task<bool> SetInactiveAsync(short id);
		bool SetInactive(short id);
		Task<short> Delete(short id);
		Task<List<Schedule>> GetActiveSchedulesBySemesterAsync(short semesterId);
		List<Schedule> GetActiveSchedulesBySemester(short semesterId);
		Task<List<Schedule>> GetActiveSchedulesByDepartmentAsync(short departmentId);
		List<Schedule> GetActiveSchedulesByDepartment(short departmentId);
		Task<List<Schedule>> GetAllActiveSchedulesAsync();
		List<Schedule> GetAllActiveSchedules();
		Task<Schedule> GetActiveScheduleByIdAsync(short id);
		Schedule GetActiveScheduleById(short id);
		Task<List<Schedule>> GetAllSchedulesAsync();
		List<Schedule> GetAllSchedules();
		
	}
}