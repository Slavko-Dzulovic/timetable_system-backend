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
	}
}