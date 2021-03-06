﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Terms
{
	public interface ITermsRepository : IRepository<Data.Entities.Term, short>
	{
		Task<Term> AddNewTermAsync(Term term);
		Term AddNewTerm(Term term);
		Task<Term> EditTermAsync(short id, DateTime startTime, DateTime endTime, short group, short noLectures, 
			short noExercises, short noLabExercises, short weekdayId, short classroomId, long slotId);
		Term EditTerm(short id, DateTime startTime, DateTime endTime, short group, short noLectures, 
			short noExercises, short noLabExercises, short weekdayId, short classroomId, long slotId);
		Task<bool> CheckIfTermExistsAsync(short id);
		Task<short> DeleteTermAsync(short id);
		Task<List<Term>> GetTermsByWeekdayAsync(short weekdayId);
		List<Term> GetTermsByWeekday(short weekdayId);
		Task<List<Term>> GetTermsByScheduleAsync(short scheduleId);
		List<Term> GetTermsBySchedule(short scheduleId);
		Task<List<Term>> GetTermsByScheduleAndWeekdayAsync(short scheduleId, short weekdayId);
		List<Term> GetTermsByScheduleAndWeekday(short scheduleId, short weekdayId);
		Term GetTermById(short id);
		bool TermOverlapsWithOthers(short? termId, DateTime start1, DateTime end1, short weekdayId, short classroomId, 
			short scheduleId, short lecturerId, short subjectId, short moduleId, short semesterId);
	}
}