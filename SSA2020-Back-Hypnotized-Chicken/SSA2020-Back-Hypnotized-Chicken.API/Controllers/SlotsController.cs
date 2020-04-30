using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots;
using SSA2020_Back_Hypnotized_Chicken.API.Models.Slots;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SlotsController : BaseController<SlotsController>
	{
		public SlotsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

		[HttpGet]
		public async Task<ActionResult<List<SlotBySemesterAndModuleDTO>>> Subjects([FromQuery] short semesterId, short moduleId)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}
			
			var validateSemesterId = await UnitOfWork.SemestersRepository.CheckIfSemesterExistsAsync(semesterId);
			var validateModuleId = await UnitOfWork.ModulesRepository.CheckIfModuleExistsAsync(moduleId);
			//Task.WaitAll(validateSemesterId, validateModuleId);
			
			if (!validateSemesterId ||
			    !validateModuleId)
			{
				return BadRequest("No semester or module by the given id exist.");
			}
			
			var list = await UnitOfWork.SlotsRepository.SubjectsBySemesterAndModuleAsync(semesterId, moduleId);
			
			if (list == null ||
			    !list.Any())
			{
				return NoContent();
			}

			var slotMapResult = Mapper.Map<List<Subject>, List<SlotBySemesterAndModuleDTO>>(list);

			return Ok(slotMapResult);
		}
	}
}