using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Classrooms
{
    public interface IClassroomsRepository : IRepository<Data.Entities.Classroom, short>
    {
        List<Classroom> GetClassrooms();
        Task<List<Classroom>> GetClassroomsAsync();
    }
}