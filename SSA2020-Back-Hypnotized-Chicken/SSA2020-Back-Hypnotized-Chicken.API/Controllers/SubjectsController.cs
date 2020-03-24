using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs;
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
		
		[HttpGet]
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
	}
}