using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Subjects;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SubjectsController : BaseController<SubjectsController>
	{
		public SubjectsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }
		
		[HttpGet("all")]
		public async Task<ActionResult<List<SubjectDTO>>> Get()
		{
			var subjects = await UnitOfWork.SubjectsRepository.GetSubjectsAsync();

			if (subjects == null || !subjects.Any())
			{
				return NoContent();
			}

			var subjectMapResult = Mapper.Map<List<Subject>, List<SubjectDTO>>(subjects);

			return Ok(subjectMapResult);
		}
		
		[HttpGet]
		public async Task<ActionResult<List<SlotBySemesterAndModuleDTO>>> Subjects([FromQuery] short semesterId, short moduleId)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}
			
			var validateSemesterId = await UnitOfWork.SemestersRepository.CheckIfSemesterExistsAsync(semesterId);
			var validateModuleId = await UnitOfWork.ModulesRepository.CheckIfModuleExistsAsync(moduleId);
			
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
		[HttpGet("{id}")]
		public SubjectDTO GetById(short id)
		{
			var subject = UnitOfWork.SubjectsRepository.GetSubjectById(id);

			var subjectMapResult = Mapper.Map<Subject, SubjectDTO>(subject);
			return subjectMapResult;
		}
	}
}