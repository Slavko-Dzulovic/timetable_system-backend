using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Terms
{
	public interface ITermsRepository : IRepository<Data.Entities.Term, short>
	{
		Task<Term> AddNewTermAsync(Term term);
		Term AddNewTerm(Term term);
		Task<Term> EditTermAsync(short id, DateTime time, short group, string module, short optional_subject_number,
			short number_of_lectures, short number_of_exercises, short number_of_lab_exercises, short weekday_id, short classroom_id);
		Term EditTerm(short id, DateTime time, short group, string module, short optional_subject_number,
			short number_of_lectures, short number_of_exercises, short number_of_lab_exercises, short weekday_id, short classroom_id);
		Task<bool> CheckIfTermExistsAsync(short id);
		Task<short> DeleteTermAsync(short id);
	}
}