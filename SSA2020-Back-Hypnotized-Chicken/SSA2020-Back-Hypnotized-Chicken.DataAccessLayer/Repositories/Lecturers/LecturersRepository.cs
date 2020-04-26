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

        public List<Lecturer> GetLecturers()
        {
            return _dbContext.Lecturers.ToList();
        }

        public async Task<List<Lecturer>> GetLecturersAsync()
        {
            return await _dbContext.Lecturers.ToListAsync();
        }
    }
}