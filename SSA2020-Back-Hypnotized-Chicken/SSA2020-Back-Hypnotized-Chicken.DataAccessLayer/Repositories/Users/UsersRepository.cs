using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SSA2020_Back_Hypnotized_Chicken.CommonHelper.Helpers;
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
			var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
			
			if (user == null)
			{
				return null;
			}

			if (!PasswordMethods.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
			{
				return null;
			}

			// authentication successful so generate jwt token
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes("obligatory secret");
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new [] 
				{
					new Claim(ClaimTypes.Name, user.Id.ToString()),
					new Claim(ClaimTypes.Role, user.Role)
				}),
				Expires = DateTime.Now.AddDays(7),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			user.Token = tokenHandler.WriteToken(token);
			
			return user.WithoutPassword();
		}

		public async Task<List<User>> GetAllAsync()
		{
			var users = await _dbContext.Users.ToListAsync();

			foreach (var user in users)
			{
				user.WithoutPassword();
			}

			return users;
		}

		public Task<User> GetByIdAsync(int id)
		{
			throw new System.NotImplementedException();
		}
		
		public async Task<User> CreateUser(string username, string password, string firstName, string lastName)
		{
			// validation
			if (string.IsNullOrWhiteSpace(password))
			{
				return null;
			}
			
			if (_dbContext.Users.Any(x => x.Username == username))
			{
				return null;
			}

			byte[] passwordHash, passwordSalt;
			PasswordMethods.CreatePasswordHash(password, out passwordHash, out passwordSalt);

			var user = new User
			{
				FirstName = firstName,
				LastName = lastName,
				Username = username,
				PasswordHash = passwordHash,
				PasswordSalt = passwordSalt,
				Role = Role.Admin,
				Token = string.Empty
			};
			
			await _dbContext.Users.AddAsync(user);
			

			return user;
		}
	}
}