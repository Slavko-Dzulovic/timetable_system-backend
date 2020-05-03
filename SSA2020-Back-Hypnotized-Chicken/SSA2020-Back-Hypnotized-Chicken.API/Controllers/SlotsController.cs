using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SlotsController : BaseController<SlotsController>
	{
		public SlotsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
	}
}