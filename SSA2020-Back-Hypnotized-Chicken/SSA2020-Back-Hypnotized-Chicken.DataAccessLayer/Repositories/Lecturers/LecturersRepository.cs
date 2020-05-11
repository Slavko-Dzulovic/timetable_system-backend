using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers
{
    public class LecturersRepository : Repository<Lecturer, short>, ILecturersRepository
    {
        private readonly TimetableDbContext _dbContext;

        public LecturersRepository(TimetableDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Lecturer>> GetLecturersAsync()
        {
            return await _dbContext.Lecturers.ToListAsync();
        }

        public List<Lecturer> GetLecturers()
        {
            return _dbContext.Lecturers.ToList();
        }

        public async Task<Lecturer> GetByIdAsync(short id)
        {
            return await _dbContext.Lecturers.FirstOrDefaultAsync(l => l.Id == id);
        }

        public Lecturer GetById(short id)
        {
            return _dbContext.Lecturers.FirstOrDefault(l => l.Id == id);
        }

        public async Task<List<Lecturer>> GetLecturersBySemesterModuleSubjectAsync(short subjectId, short moduleId, short semesterId)
        {
            var queryResultAsync = await _dbContext.Slots
                .Include(m => m.Module)
                .Include(s => s.Semester)
                .Include(s => s.Subject)
                .Where(slot => slot.SemesterId == semesterId &&
                               slot.ModuleId == moduleId &&
                               slot.SubjectId == subjectId)
                .Select(l => l.Lecturer)
                .ToListAsync();

            return queryResultAsync;
        }

        public List<Lecturer> GetLecturersBySemesterModuleSubject(short subjectId, short moduleId, short semesterId)
        {
            var queryResult = _dbContext.Slots
                .Include(m => m.ModuleId)
                .Include(s => s.Semester)
                .Include(s => s.Subject)
                .Where(slot => slot.SemesterId == semesterId &&
                               slot.SubjectId == subjectId &&
                               slot.ModuleId == moduleId)
                .Select(l => l.Lecturer)
                .ToList();

            return queryResult;
        }
    }
}