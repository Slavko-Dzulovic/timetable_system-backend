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

		public async Task<Term> EditTermAsync(short id, DateTime time, short group, string module, short optional_subject_number,
			short number_of_lectures, short number_of_exercises, short number_of_lab_exercises, short weekday_id, short classroom_id)
		{
			var term = await _dbContext.Terms.FirstOrDefaultAsync(t => t.Id == id);
			if (term == null)
			{
				return null;
			}

			term.Time = time;
			term.Group = group;
			term.Module = module;
			term.OptionalSubjectNumber = optional_subject_number;
			term.NumberOfLectures = number_of_lectures;
			term.NumberOfExercises = number_of_exercises;
			term.NumberOfLabExercises = number_of_lab_exercises;
			term.WeekdayId = weekday_id;
			term.ClassroomId = classroom_id;

			return await _dbContext.SaveChangesAsync() > 0 ? term : null;
		}

		public Term EditTerm(short id, DateTime time, short group, string module, short optional_subject_number,
			short number_of_lectures, short number_of_exercises, short number_of_lab_exercises, short weekday_id, short classroom_id)
		{
			var term = _dbContext.Terms.FirstOrDefault(t => t.Id == id);
			if (term == null)
			{
				return null;
			}

			term.Time = time;
			term.Group = group;
			term.Module = module;
			term.OptionalSubjectNumber = optional_subject_number;
			term.NumberOfLectures = number_of_lectures;
			term.NumberOfExercises = number_of_exercises;
			term.NumberOfLabExercises = number_of_lab_exercises;
			term.WeekdayId = weekday_id;
			term.ClassroomId = classroom_id;

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
	}
}