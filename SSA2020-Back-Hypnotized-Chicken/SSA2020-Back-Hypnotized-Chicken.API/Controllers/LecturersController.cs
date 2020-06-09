using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Lecturers;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LecturersController : BaseController<LecturersController>
    {
        public LecturersController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        [HttpGet]
        public async Task<ActionResult<List<LecturerDTO>>> Get()
        {
            var lecturers = await UnitOfWork.LecturersRepository.GetLecturersAsync();

            if (lecturers == null || !lecturers.Any())
            {
                return NoContent();
            }

            var lecturerMapResult = Mapper.Map<List<Lecturer>, List<LecturerDTO>>(lecturers);

            return Ok(lecturerMapResult);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LecturerDTO>> Get([FromRoute] short id)
        {
            var lecturer = await UnitOfWork.LecturersRepository.GetByIdAsync(id);
            if (lecturer == null)
            {
                return BadRequest("Requested lecturer doesn't exist.");
            }

            var lecturerMapResult = Mapper.Map<Lecturer, LecturerDTO>(lecturer);

            return Ok(lecturerMapResult);
        }

        [HttpGet("by_subject")]
        public async Task<ActionResult<List<LecturerDTO>>> GetBySemesterModuleSubject([FromQuery] short subjectId, short moduleId, short semesterId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not all of the needed information is supplied.");
            }

            var validateSemesterId = await UnitOfWork.SemestersRepository.CheckIfSemesterExistsAsync(semesterId);
            var validateSubjectId = await UnitOfWork.SubjectsRepository.CheckIfSubjectExistsAsync(subjectId);
            var validateModuleId = await UnitOfWork.ModulesRepository.CheckIfModuleExistsAsync(moduleId);
            
            if (!validateSemesterId ||
                !validateModuleId ||
                !validateSubjectId)
            {
                return BadRequest("No semester or module or subject by the given id exist.");
            }
            
            var lecturers = await UnitOfWork.LecturersRepository
                .GetLecturersBySemesterModuleSubjectAsync(subjectId, moduleId, semesterId);

            if (lecturers == null ||
                !lecturers.Any())
            {
                return NoContent();
            }

            var lecturerMapResult = Mapper.Map<List<Lecturer>, List<LecturerDTO>>(lecturers);

            return Ok(lecturerMapResult);
        }
    }
}