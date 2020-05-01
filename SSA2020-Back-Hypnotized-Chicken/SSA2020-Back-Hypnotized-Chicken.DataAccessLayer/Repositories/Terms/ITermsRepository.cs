using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Terms
{
	public interface ITermsRepository : IRepository<Data.Entities.Term, short>
	{
		Task<Term> AddNewTermAsync(Term term);
		Term AddNewTerm(Term term);
	}
}