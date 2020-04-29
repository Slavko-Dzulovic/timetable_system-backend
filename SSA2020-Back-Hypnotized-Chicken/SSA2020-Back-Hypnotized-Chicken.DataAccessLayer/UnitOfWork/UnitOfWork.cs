using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Departments;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Schedules;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Modules;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly TimetableDbContext _dbContext;

		public UnitOfWork(TimetableDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		private ISubjectsRepository _subjectsRepository;
        private IClassroomsRepository _classroomsRepository;
        private ILecturersRepository _lecturersRepository;
        private ISchedulesRepository _schedulesRepository;
        private IDepartmentsRepository _departmentsRepository;
        private ISemestersRepository _semestersRepository;
		private IModulesRepository _modulesRepository;

		public ISubjectsRepository SubjectsRepository =>
			this._subjectsRepository ?? (this._subjectsRepository = new SubjectsRepository(_dbContext));
        public IClassroomsRepository ClassroomsRepository =>
            this._classroomsRepository ?? (this._classroomsRepository = new ClassroomsRepository(_dbContext));

        public ILecturersRepository LecturersRepository =>
            this._lecturersRepository ?? (this._lecturersRepository = new LecturersRepository(_dbContext));
        
        public ISchedulesRepository SchedulesRepository =>
	        this._schedulesRepository ?? (this._schedulesRepository = new SchedulesRepository(_dbContext));

		public IDepartmentsRepository DepartmentsRepository =>
			this._departmentsRepository ?? (this._departmentsRepository = new DepartmentsRepository(_dbContext));

		public ISemestersRepository SemestersRepository =>
			this._semestersRepository ?? (this._semestersRepository = new SemestersRepository(_dbContext));

		public IModulesRepository ModulesRepository =>
			this._modulesRepository ?? (this._modulesRepository = new ModulesRepository(_dbContext));

		public Task SaveChangesAsync()
		{
			return _dbContext.SaveChangesAsync();
		}

		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}
	}
}