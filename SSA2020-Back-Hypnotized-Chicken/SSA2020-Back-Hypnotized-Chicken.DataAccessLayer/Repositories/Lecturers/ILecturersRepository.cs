using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers
{
    public interface ILecturersRepository : IRepository<Data.Entities.Lecturer, short>
    {
        List<Lecturer> GetLecturers();
        Task<List<Lecturer>> GetLecturersAsync();
    }
}