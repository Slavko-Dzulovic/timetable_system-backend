using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Subjects;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers;

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

        public ISubjectsRepository SubjectsRepository =>
			this._subjectsRepository ?? (this._subjectsRepository = new SubjectsRepository(_dbContext));
        public IClassroomsRepository ClassroomsRepository =>
            this._classroomsRepository ?? (this._classroomsRepository = new ClassroomsRepository(_dbContext));

        public ILecturersRepository LecturersRepository =>
            this._lecturersRepository ?? (this._lecturersRepository = new LecturersRepository(_dbContext));


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