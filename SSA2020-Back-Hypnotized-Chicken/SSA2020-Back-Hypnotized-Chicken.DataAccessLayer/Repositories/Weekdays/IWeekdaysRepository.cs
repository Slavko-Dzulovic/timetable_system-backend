using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Weekdays
{
    public interface IWeekdaysRepository : IRepository<Data.Entities.Weekday, short>
    {
        Task<bool> CheckIfWeekdayExistsAsync(short id);
        Task<List<Weekday>> GetAllWeekdaysAsync();
        List<Weekday> GetAllWeekdays();
    }
}
