using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms
{
    public class ClassroomsRepository : Repository<Classroom, short>, IClassroomsRepository
    {
        private readonly TimetableDbContext _dbContext;

        public ClassroomsRepository(TimetableDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Classroom> GetClassrooms()
        {
            return _dbContext.Classrooms.ToList();
        }

        public async Task<List<Classroom>> GetClassroomsAsync()
        {
            return await _dbContext.Classrooms.ToListAsync();
        }
    }
}