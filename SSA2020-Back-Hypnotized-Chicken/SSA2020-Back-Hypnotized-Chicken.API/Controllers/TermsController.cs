using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Terms;
using SSA2020_Back_Hypnotized_Chicken.API.Models;
using SSA2020_Back_Hypnotized_Chicken.API.Models.Terms;
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
			
			Regex regex = new Regex("^([0-1]?[0-9]|2[0-3]):([0-5][0-9])$");

			var matchStartTime = regex.Match(term.StartTime);
			var matchEndTime = regex.Match(term.EndTime);

			var startTimeDT = new DateTime(2017, 1, 1, int.Parse(matchStartTime.Groups[1].Value), int.Parse(matchStartTime.Groups[2].Value), 0);
			var endTimeDT = new DateTime(2017, 1, 1, int.Parse(matchEndTime.Groups[1].Value), int.Parse(matchEndTime.Groups[2].Value), 0);

			if (UnitOfWork.TermsRepository.TermOverlapsWithOthers(null, startTimeDT, endTimeDT, term.WeekdayId, term.ClassroomId, term.ScheduleId))
			{
				return BadRequest("The created term overlaps with other terms. Please pick another start and end time.");
			}

			var savedTerm = await UnitOfWork.TermsRepository.AddNewTermAsync(

				new Term
				{
					StartTime = startTimeDT,
					EndTime = endTimeDT,
					Group = term.Group,
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

			var slotId = UnitOfWork.SlotsRepository.GetSlotIdByAllForeignKeys(data.SubjectId, data.ModuleId, data.SemesterId, data.LecturerId);

			var validateWeekdayId = await UnitOfWork.WeekdaysRepository.CheckIfWeekdayExistsAsync(data.WeekdayId);
			var validateClassroomId = await UnitOfWork.ClassroomsRepository.CheckIfClassroomExistsAsync(data.ClassroomId);
			var validateSlotId = await UnitOfWork.SlotsRepository.CheckIfSlotExistsAsync(slotId);
			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(data.ScheduleId);

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

			Regex regex = new Regex("^([0-1]?[0-9]|2[0-3]):([0-5][0-9])$");

			var matchStartTime = regex.Match(data.StartTime);
			var matchEndTime = regex.Match(data.EndTime);

			var startTimeDT = new DateTime(2017, 1, 1, int.Parse(matchStartTime.Groups[1].Value), int.Parse(matchStartTime.Groups[2].Value), 0);
			var endTimeDT = new DateTime(2017, 1, 1, int.Parse(matchEndTime.Groups[1].Value), int.Parse(matchEndTime.Groups[2].Value), 0);

			if (UnitOfWork.TermsRepository.TermOverlapsWithOthers(data.Id, startTimeDT, endTimeDT, data.WeekdayId, data.ClassroomId, data.ScheduleId))
			{
				return BadRequest("The created term overlaps with others. Please pick another start and end time.");
			}

			var editTerm = await UnitOfWork.TermsRepository.EditTermAsync(data.Id, startTimeDT, endTimeDT, data.Group, data.NumberOfLectures, data.NumberOfExercises, data.NumberOfLabExercises,
				data.WeekdayId, data.ClassroomId, slotId);


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

		[HttpGet("{id}")]
		public TermDTO GetById(short id)
		{
			var term = UnitOfWork.TermsRepository.GetTermById(id);

			var termMapResult = Mapper.Map<Term, TermDTO>(term);
			return termMapResult;
		}
	}
}