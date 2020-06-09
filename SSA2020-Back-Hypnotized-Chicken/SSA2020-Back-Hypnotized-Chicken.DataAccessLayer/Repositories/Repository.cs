using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories
{
    public class Repository<T, TK> : IRepository<T, TK> where T : Entity<TK> where TK : struct
    {
        private readonly TimetableDbContext _dbContext;
        
        public Repository(TimetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}