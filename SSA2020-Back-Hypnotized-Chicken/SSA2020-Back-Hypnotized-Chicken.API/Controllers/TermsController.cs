using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Terms;
using SSA2020_Back_Hypnotized_Chicken.API.Models;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TermsController : BaseController<TermsController>
	{
		public TermsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

		[HttpPost]
		[ProducesResponseType(typeof(TermDTO), StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<TermDTO>> Post([FromBody]TermPostObject term)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}

			var slotId = UnitOfWork.SlotsRepository.GetSlotIdByAllForeignKeys(term.SubjectId, term.ModuleId, term.SemesterId, term.LecturerId);
			var module = UnitOfWork.ModulesRepository.GetModuleById(term.ModuleId).Name;

			var validateWeekdayId = await UnitOfWork.WeekdaysRepository.CheckIfWeekdayExistsAsync(term.WeekdayId);
			var validateClassroomId = await UnitOfWork.ClassroomsRepository.CheckIfClassroomExistsAsync(term.ClassroomId);
			var validateSlotId = await UnitOfWork.SlotsRepository.CheckIfSlotExistsAsync(slotId);
			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(term.ScheduleId);

			if (!validateWeekdayId)
			{
				return BadRequest("No weekday by the given id exists.");
			}
			if (!validateClassroomId)
			{
				return BadRequest("No classroom by the given id exists.");
			}
			if (!validateSlotId)
			{
				return BadRequest("No slot by the given id exists.");
			}
			if (!validateScheduleId)
			{
				return BadRequest("No schedule by the given id exists.");
			}

			var savedTerm = await UnitOfWork.TermsRepository.AddNewTermAsync(
				new Term
				{
					StartTime = term.StartTime,
					EndTime = term.EndTime,
					Group = term.Group,
					Module = module,
					NumberOfLectures = term.NumberOfLectures,
					NumberOfExercises = term.NumberOfExercises,
					NumberOfLabExercises = term.NumberOfLabExercises,
					WeekdayId = term.WeekdayId,
					ClassroomId = term.ClassroomId,
					ScheduleId = term.ScheduleId,
					SlotId = slotId
				}
			);

			if (savedTerm == null)
			{
				return BadRequest("Error saving term to DB");
			}

			await UnitOfWork.SaveChangesAsync();

			var termMapResult = Mapper.Map<Term, TermDTO>(savedTerm);

			return Created(string.Empty, termMapResult);
		}

		[HttpPut]
		public async Task<ActionResult<TermDTO>> Put([FromBody]TermEditObject data)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}

			var validateTermId = await UnitOfWork.TermsRepository.CheckIfTermExistsAsync(data.Id);

			if (!validateTermId)
			{
				return BadRequest("No term by the given id exists.");
			}

			var editTerm = await UnitOfWork.TermsRepository.EditTermAsync(data.Id, data.StartTime, data.EndTime, data.Group, data.Module, data.NumberOfLectures, data.NumberOfExercises, data.NumberOfLabExercises,
				data.WeekdayId, data.ClassroomId);

			if (editTerm == null)
			{
				return Conflict();
			}

			var termMapResult = Mapper.Map<Term, TermDTO>(editTerm);

			return Ok(termMapResult);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<TermDTO>> Delete([FromRoute] short id)
		{
			var validateTermId = await UnitOfWork.TermsRepository.CheckIfTermExistsAsync(id);
			if (!validateTermId)
			{
				return BadRequest("No term with such id exists.");
			}
			
			var deletedTermId = await UnitOfWork.TermsRepository.DeleteTermAsync(id);
			if (deletedTermId == 0)
			{
				return BadRequest("Error deleting term.");
			}

			await UnitOfWork.SaveChangesAsync();

			return Ok();
		}

		[HttpGet("by_weekday")]
		public async Task<ActionResult<List<TermDTO>>> GetByWeekday(short weekdayId)
		{
			var validateWeekdayId = await UnitOfWork.WeekdaysRepository.CheckIfWeekdayExistsAsync(weekdayId);
			if (!validateWeekdayId)
			{
				return BadRequest("No such weekday exists.");
			}

			var terms = await UnitOfWork.TermsRepository.GetTermsByWeekdayAsync(weekdayId);
			if (terms == null ||
			    !terms.Any())
			{
				return NoContent();
			}

			var termsMapResult = Mapper.Map<List<Term>, List<TermDTO>>(terms);

			return termsMapResult;
		}
		
		[HttpGet("by_schedule")]
		public async Task<ActionResult<List<TermDTO>>> GetBySchedule(short scheduleId)
		{
			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(scheduleId);
			if (!validateScheduleId)
			{
				return BadRequest("No such schedule exists.");
			}

			var terms = await UnitOfWork.TermsRepository.GetTermsByScheduleAsync(scheduleId);
			if (terms == null ||
			    !terms.Any())
			{
				return NoContent();
			}

			var termsMapResult = Mapper.Map<List<Term>, List<TermDTO>>(terms);

			return termsMapResult;
		}

		[HttpGet("by_schedule_and_weekday")]
		public async Task<ActionResult<List<TermDTO>>> Terms([FromQuery] short scheduleId, short weekdayId)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}

			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(scheduleId);
			var validateWeekdayId = await UnitOfWork.WeekdaysRepository.CheckIfWeekdayExistsAsync(weekdayId);

			if (!validateScheduleId ||
				!validateWeekdayId)
			{
				return BadRequest("No schedule or weekday by the given id exist.");
			}

			var list = await UnitOfWork.TermsRepository.GetTermsByScheduleAndWeekdayAsync(scheduleId, weekdayId);

			if (list == null ||
				!list.Any())
			{
				return NoContent();
			}

			var termMapResult = Mapper.Map<List<Term>, List<TermDTO>>(list);

			return Ok(termMapResult);
		}
	}
}