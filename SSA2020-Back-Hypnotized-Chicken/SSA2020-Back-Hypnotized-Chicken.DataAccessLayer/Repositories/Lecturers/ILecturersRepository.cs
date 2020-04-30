using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Lecturers
{
    public interface ILecturersRepository : IRepository<Data.Entities.Lecturer, short>
    {
        Task<List<Lecturer>> GetLecturersBySemesterModuleSubjectAsync(short subjectId, short moduleId, short semesterId);
        List<Lecturer> GetLecturersBySemesterModuleSubject(short subjectId, short moduleId, short semesterId);
        Task<List<Lecturer>> GetLecturersAsync();
        List<Lecturer> GetLecturers();
        
    }
}