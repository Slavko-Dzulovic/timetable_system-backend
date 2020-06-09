using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Users;
using SSA2020_Back_Hypnotized_Chicken.API.Models.Users;
using SSA2020_Back_Hypnotized_Chicken.CommonHelper.Helpers;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/[controller]")]
	public class UsersController : BaseController<UsersController>
	{
		public UsersController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
		
		[AllowAnonymous]
		[HttpPost("authenticate")]
		public async Task<ActionResult<UserDTO>> Authenticate([FromBody]UserLoginModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the required information is supplied.");
			}
			
			var user = await UnitOfWork.UsersRepository.AuthenticateAsync(model.Username, model.Password);

			if (user == null)
			{
				return BadRequest("Username or password is incorrect.");
			}

			var userMapResult = Mapper.Map<User, UserDTO>(user);

			return Ok(userMapResult);
		}
		
		[Authorize(Roles = Role.Admin)]
		[HttpGet]
		public async Task<ActionResult<List<UserDTO>>> GetAll()
		{
			var users = await UnitOfWork.UsersRepository.GetAllAsync();

			var userMapResult = Mapper.Map<List<User>, List<UserDTO>>(users);
			
			return Ok(userMapResult);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<UserDTO>> GetById(int id)
		{
			// only allow admins to access other user records
			var currentUserId = int.Parse(User.Identity.Name ?? string.Empty);
			if (id != currentUserId && !User.IsInRole(Role.Admin))
			{
				return Forbid();
			}

			var user = await UnitOfWork.UsersRepository.GetByIdAsync(id);

			if (user == null)
			{
				return Forbid();
			}

			var userMapResult = Mapper.Map<User, UserDTO>(user);
			
			return Ok(userMapResult);
		}
		
		[AllowAnonymous]
		[HttpPost("register")]
		public async Task<ActionResult<UserDTO>> Post([FromBody]UserRegisterModel userRegisterModel)
		{
			if (!ModelState.IsValid)
			{ 
				return BadRequest("Not all of the needed information is supplied.");
			}

			userRegisterModel.Password = PasswordMethods.GeneratePassword(true, true, true, true, 16);

			var savedUser = await UnitOfWork.UsersRepository.CreateUser(userRegisterModel.Username, userRegisterModel.Password,
																	    userRegisterModel.FirstName, userRegisterModel.LastName);

			if (savedUser == null)
			{
				return BadRequest("Error saving user to DB");
			}
			
			var sendEmailResult = EmailMethods.SendEmail(userRegisterModel.Username, userRegisterModel.FirstName,
				userRegisterModel.LastName, userRegisterModel.Password);

			if (!sendEmailResult)
			{
				BadRequest("Email is not sent!");
			}
			
			await UnitOfWork.SaveChangesAsync();

			var userMapResult = Mapper.Map<User, UserDTO>(savedUser);

			return Created(string.Empty, userMapResult);
		}
	}
}