using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Schedules;
using SSA2020_Back_Hypnotized_Chicken.API.Models;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class SchedulesController : BaseController<SchedulesController>
	{
		public SchedulesController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) {}
		
		[HttpPost]
		[ProducesResponseType(typeof(ScheduleDTO), StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<ScheduleDTO>> Post([FromBody]SchedulePostObject schedule)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}

			var validateSemesterId = await UnitOfWork.SemestersRepository.CheckIfSemesterExistsAsync(schedule.SemesterId);
			var validateDepartmentId = await UnitOfWork.DepartmentsRepository.CheckIfDepartmentExistsAsync(schedule.DepartmentId);
			// Task.WaitAll(validateDepartmentId, validateSemesterId);

			if (!validateSemesterId ||
			    !validateDepartmentId)
			{
				return BadRequest("No semester or department by the given id exist.");
			}

			var savedSchedule = await UnitOfWork.SchedulesRepository.AddNewScheduleAsync(
				new Schedule
				{
					Name = string.Join("_", ((Semesters) schedule.SemesterId).ToString(),
						((Departments) schedule.DepartmentId).ToString()),
					DepartmentId = schedule.DepartmentId,
					SemesterId = schedule.SemesterId,
					IsActive = true
				}
			);

			if (savedSchedule == null)
			{
				return BadRequest("Error saving schedule to DB");
			}

			await UnitOfWork.SaveChangesAsync();

			var scheduleMapResult = Mapper.Map<Schedule, ScheduleDTO>(savedSchedule);

			return Created(string.Empty, scheduleMapResult);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<ScheduleDTO>> Delete([FromRoute] short id)
		{
			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(id);
			if (!validateScheduleId)
			{
				return BadRequest("No schedule by the given id exists.");
			}

			var updateSchedule = await UnitOfWork.SchedulesRepository.SetInactiveAsync(id);
			if (!updateSchedule)
			{
				return BadRequest("Error updating schedule.");
			}

			await UnitOfWork.SaveChangesAsync();

			return Ok();
		}

		[HttpPut]
		public async Task<ActionResult<ScheduleDTO>> Put([FromBody]ScheduleEditObject data)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest("Not all of the needed information is supplied.");
			}

			var validateScheduleId = await UnitOfWork.SchedulesRepository.CheckIfScheduleExistsAsync(data.Id);

			if (!validateScheduleId)
			{
				return BadRequest("No schedule by the given id exists.");
			}

			var editSchedule = await UnitOfWork.SchedulesRepository.EditScheduleAsync(data.Id, data.Name);

			if (editSchedule == null)
			{
				return Conflict();
			}

			var scheduleMapResult = Mapper.Map<Schedule, ScheduleDTO>(editSchedule);

			return Ok(scheduleMapResult);
		}

		[HttpGet]
		public async Task<ActionResult<List<ScheduleDTO>>> Get()
		{
			var schedules = await UnitOfWork.SchedulesRepository.GetAllActiveSchedulesAsync();
			if (schedules == null ||
			    !schedules.Any())
			{
				return NoContent();
			}

			var scheduleMapResult = Mapper.Map<List<Schedule>, List<ScheduleDTO>>(schedules);

			return Ok(scheduleMapResult);
		}

		[HttpGet("by_semester")]
		public async Task<ActionResult<List<ScheduleDTO>>> GetActiveBySemester([FromQuery] short semesterId)
		{
			var validateSemesterId = await UnitOfWork.SemestersRepository.CheckIfSemesterExistsAsync(semesterId);
			if (!validateSemesterId)
			{
				return BadRequest("No semester by the given id exists.");
			}

			var schedules = await UnitOfWork.SchedulesRepository
				.GetActiveSchedulesBySemesterAsync(semesterId);

			if (schedules == null ||
			    !schedules.Any())
			{
				return NoContent();
			}

			var scheduleMapResult = Mapper.Map<List<Schedule>, List<ScheduleDTO>>(schedules);

			return Ok(scheduleMapResult);
		}

		[HttpGet("by_department")]
		public async Task<ActionResult<List<ScheduleDTO>>> GetActiveByDepartment([FromQuery] short departmentId)
		{
			var validateDepartmentId = await UnitOfWork.DepartmentsRepository.CheckIfDepartmentExistsAsync(departmentId);
			if (!validateDepartmentId)
			{
				return BadRequest("No department by the given id exists.");
			}

			var schedules = await UnitOfWork.SchedulesRepository.GetActiveSchedulesByDepartmentAsync(departmentId);

			if (schedules == null ||
			    !schedules.Any())
			{
				return NoContent();
			}

			var scheduleMapResult = Mapper.Map<List<Schedule>, List<ScheduleDTO>>(schedules);

			return Ok(scheduleMapResult);
		}
	}
}