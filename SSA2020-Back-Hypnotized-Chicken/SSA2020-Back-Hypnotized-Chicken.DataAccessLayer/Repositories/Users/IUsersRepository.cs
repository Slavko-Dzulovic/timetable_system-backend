using System.Collections.Generic;
using System.Threading.Tasks;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Users
{
	public interface IUsersRepository : IRepository<User, short>
	{
		Task<User> AuthenticateAsync(string username, string password);
		Task<List<User>> GetAllAsync();
		Task<User> GetByIdAsync(int id);
	}
}