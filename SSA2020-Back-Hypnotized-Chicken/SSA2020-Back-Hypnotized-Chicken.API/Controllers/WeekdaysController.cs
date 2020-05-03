using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Weekdays;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class WeekdaysController : BaseController<WeekdaysController>
	{
		public WeekdaysController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

		[HttpGet]
		public async Task<ActionResult<List<WeekdayDTO>>> Get()
		{
			var weekdays = await UnitOfWork.WeekdaysRepository.GetAllWeekdaysAsync();
			if (weekdays == null ||
			    !weekdays.Any())
			{
				return NoContent();
			}

			var weekdayMapResult = Mapper.Map<List<Weekday>, List<WeekdayDTO>>(weekdays);

			return Ok(weekdayMapResult);
		}
	}
}