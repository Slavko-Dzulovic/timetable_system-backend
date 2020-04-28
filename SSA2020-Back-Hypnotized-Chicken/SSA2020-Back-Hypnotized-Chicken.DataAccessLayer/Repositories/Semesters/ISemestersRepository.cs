using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Semesters
{
    public interface ISemestersRepository : IRepository<Data.Entities.Semester, short>
    {
        List<Semester> GetSemesters();
        Task<List<Semester>> GetSemestersAsync();
    }
}