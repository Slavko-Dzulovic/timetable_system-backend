using System;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Schedules;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Modules;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Slots;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Terms;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Users;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Weekdays;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		ISubjectsRepository SubjectsRepository { get; }
        IClassroomsRepository ClassroomsRepository { get; }
        ILecturersRepository LecturersRepository { get; }
        ISchedulesRepository SchedulesRepository { get; }
        IDepartmentsRepository DepartmentsRepository { get; }
        ISemestersRepository SemestersRepository { get; }
		IModulesRepository ModulesRepository { get; }
		ISlotsRepository SlotsRepository { get;  }
		ITermsRepository TermsRepository { get; }
		IWeekdaysRepository WeekdaysRepository { get; }
		IUsersRepository UsersRepository { get; }
		
		/// <summary>
		/// Save context changes async
		/// </summary>
		/// <returns>Return task operation.</returns>
		Task SaveChangesAsync();

		/// <summary>
		/// Save context changes
		/// </summary>
		void SaveChanges();
	}
}