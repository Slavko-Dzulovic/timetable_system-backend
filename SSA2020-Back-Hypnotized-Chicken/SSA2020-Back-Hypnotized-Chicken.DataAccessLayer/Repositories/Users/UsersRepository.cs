using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SSA2020_Back_Hypnotized_Chicken.Data;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Repositories.Users
{
	public class UsersRepository : Repository<User, short>, IUsersRepository
	{
		private readonly TimetableDbContext _dbContext;
		
		public UsersRepository(TimetableDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<User> AuthenticateAsync(string username, string password)
		{
			var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username &&
			                                                           u.Password == password);
			
			if (user == null)
			{
				return null;
			}

			// authentication successful so generate jwt token
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes("secret, obviously");
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new [] 
				{
					new Claim(ClaimTypes.Name, user.Id.ToString()),
					new Claim(ClaimTypes.Role, user.Role)
				}),
				Expires = DateTime.UtcNow.AddDays(7),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			user.Token = tokenHandler.WriteToken(token);
			
			user.Password = null;
			return user;
		}

		public async Task<List<User>> GetAllAsync()
		{
			var users = await _dbContext.Users.ToListAsync();

			foreach (var user in users)
			{
				user.Password = null;
			}

			return users;
		}

		public Task<User> GetByIdAsync(int id)
		{
			throw new System.NotImplementedException();
		}
	}
}