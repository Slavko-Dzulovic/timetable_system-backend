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
    }
}