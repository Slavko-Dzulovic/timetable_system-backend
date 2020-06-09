using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SlotsController : BaseController<SlotsController>
	{
		public SlotsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

		[HttpGet("{id}")]
        public SlotDTO GetById(long id)
        {
            var slot = UnitOfWork.SlotsRepository.GetSlotById(id);

            var slotMapResult = Mapper.Map<Slot, SlotDTO>(slot);
            return slotMapResult;
        }
	}
}