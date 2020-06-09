using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories
{
    public interface IRepository<T, TK> where T : Entity<TK> where TK : struct
    {
        
    }
}