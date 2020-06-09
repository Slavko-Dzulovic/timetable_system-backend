using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	public class BaseController<TController> : ControllerBase where TController : ControllerBase
	{
		protected readonly IMapper Mapper;
		protected IUnitOfWork UnitOfWork;

		public BaseController(IMapper mapper, IUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}
	}
}