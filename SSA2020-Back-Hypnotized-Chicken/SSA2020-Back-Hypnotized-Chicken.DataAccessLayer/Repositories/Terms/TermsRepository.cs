using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Terms
{
	public class TermsRepository : Repository<Term, short>, ITermsRepository
	{
		private readonly TimetableDbContext _dbContext;

		public TermsRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Term> AddNewTermAsync(Term term)
		{
			var checkIfAlreadyAddedQuery = await _dbContext.Terms.AnyAsync(t => t.Id == term.Id);
			if (checkIfAlreadyAddedQuery)
			{
				return null;
			}
			await _dbContext.Terms.AddAsync(term);
			return term;
		}

		public Term AddNewTerm(Term term)
		{
			var checkIfAlreadyAddedQuery = _dbContext.Terms.Any(t => t.Id == term.Id);
			if (checkIfAlreadyAddedQuery)
			{
				return null;
			}
			_dbContext.Terms.Add(term);
			return term;
		}

		public async Task<Term> EditTermAsync(short id, DateTime startTime, DateTime endTime, short group, string module, short noLectures, 
			short noExercises, short noLabExercises, short weekdayId, short classroomId)
		{
			var term = await _dbContext.Terms.FirstOrDefaultAsync(t => t.Id == id);
			if (term == null)
			{
				return null;
			}

			term.StartTime = startTime;
			term.EndTime = endTime;
			term.Group = group;
			term.Module = module;
			term.NumberOfLectures = noLectures;
			term.NumberOfExercises = noExercises;
			term.NumberOfLabExercises = noLabExercises;
			term.WeekdayId = weekdayId;
			term.ClassroomId = classroomId;

			return await _dbContext.SaveChangesAsync() > 0 ? term : null;
		}

		public Term EditTerm(short id, DateTime startTime, DateTime endTime, short group, string module, short noLectures, 
			short noExercises, short noLabExercises, short weekdayId, short classroomId)
		{
			var term = _dbContext.Terms.FirstOrDefault(t => t.Id == id);
			if (term == null)
			{
				return null;
			}

			term.StartTime = startTime;
			term.EndTime = endTime;
			term.Group = group;
			term.Module = module;
			term.NumberOfLectures = noLectures;
			term.NumberOfExercises = noExercises;
			term.NumberOfLabExercises = noLabExercises;
			term.WeekdayId = weekdayId;
			term.ClassroomId = classroomId;

			return _dbContext.SaveChanges() > 0 ? term : null;
		}

		public async Task<bool> CheckIfTermExistsAsync(short id)
		{
			return await _dbContext.Terms.AnyAsync(t => t.Id == id);
		}

		public async Task<short> DeleteTermAsync(short id)
		{
			var term = _dbContext.Terms.FirstOrDefault(t => t.Id == id);
			if (term == null)
			{
				return 0;
			}

			_dbContext.Terms.Remove(term);
			await _dbContext.SaveChangesAsync();
			return id;

		}

		public async Task<List<Term>> GetTermsByWeekdayAsync(short weekdayId)
		{
			return await _dbContext.Terms.Where(t => t.WeekdayId == weekdayId).ToListAsync();
		}

		public List<Term> GetTermsByWeekday(short weekdayId)
		{
			return _dbContext.Terms.Where(t => t.WeekdayId == weekdayId).ToList();
		}

		public async Task<List<Term>> GetTermsByScheduleAsync(short scheduleId)
		{
			return await _dbContext.Terms.Where(t => t.ScheduleId == scheduleId).ToListAsync();
		}

		public List<Term> GetTermsBySchedule(short scheduleId)
		{
			return _dbContext.Terms.Where(t => t.ScheduleId == scheduleId).ToList();
		}

		public Task<List<Term>> GetTermsByScheduleAndWeekdayAsync(short scheduleId, short weekdayId)
		{
			var queryResultAsync = _dbContext.Terms
				.Include(sch => sch.Schedule)
				.Include(wd => wd.Weekday)
				.Where(t => t.ScheduleId == scheduleId && t.WeekdayId == weekdayId)
				.Select(term => term)
				.Distinct()
				.ToListAsync();

			return queryResultAsync;
		}

		public List<Term> GetTermsByScheduleAndWeekday(short scheduleId, short weekdayId)
		{
			var queryResult = _dbContext.Terms
				.Include(sch => sch.Schedule)
				.Include(wd => wd.Weekday)
				.Where(t => t.ScheduleId == scheduleId && t.WeekdayId == weekdayId)
				.Select(term => term)
				.Distinct()
				.ToList();

			return queryResult;
		}

		public Term GetTermById(short id)
		{
			return _dbContext.Terms.FirstOrDefault(t => t.Id == id);
		}
	}
}