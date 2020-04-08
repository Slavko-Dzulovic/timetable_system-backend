using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters
{
    public class SemestersRepository : Repository<Semester, short>, ISemestersRepository
    {
        private readonly TimetableDbContext _dbContext;

        public SemestersRepository(TimetableDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Semester> GetSemesters()
        {
            return _dbContext.Semesters.ToList();
        }

        public async Task<List<Semester>> GetSemestersAsync()
        {
            return await _dbContext.Semesters.ToListAsync();
        }
    }
}