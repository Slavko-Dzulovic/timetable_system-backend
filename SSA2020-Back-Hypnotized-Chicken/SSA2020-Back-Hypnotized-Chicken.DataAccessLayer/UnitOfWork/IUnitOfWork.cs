using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Modules;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork
{
	public interface IUnitOfWork
	{
		ISubjectsRepository SubjectsRepository { get; }
        IClassroomsRepository ClassroomsRepository { get; }
        ILecturersRepository LecturersRepository { get; }
		IDepartmentsRepository DepartmentsRepository { get; }
		ISemestersRepository SemestersRepository { get; }
		IModulesRepository ModulesRepository { get; }
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