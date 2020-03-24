using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork
{
	public interface IUnitOfWork
	{
		ISubjectsRepository SubjectsRepository { get; }
		
		/// <summary>
		/// Save context changes async
		/// </summary>
		/// <returns>Return task operation.</returns>
		Task SaveChangesAsync();

		/// <summary>
		/// Save context changes
		/// </summary>
		void SaveChanges();

		/// <summary>
		/// Dispose context
		/// </summary>
		void Dispose();
	}
}