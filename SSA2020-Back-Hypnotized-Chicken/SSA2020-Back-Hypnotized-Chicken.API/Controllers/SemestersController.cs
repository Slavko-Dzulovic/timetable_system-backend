using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Semesters;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemestersController : BaseController<SemestersController>
    {
        public SemestersController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        [HttpGet]
        public async Task<ActionResult<List<SemesterDTO>>> Get()
        {
            var semesters = await UnitOfWork.SemestersRepository.GetSemestersAsync();

            if (semesters == null || !semesters.Any())
            {
                return NoContent();
            }

            var semesterMapResult = Mapper.Map<List<Semester>, List<SemesterDTO>>(semesters);

            return Ok(semesterMapResult);
        }
        [HttpGet("{id}")]
        public SemesterDTO GetById(int id)
        {
            var semester = UnitOfWork.SemestersRepository.GetSemesterById(id);
           
            var semesterMapResult = Mapper.Map<Semester, SemesterDTO>(semester);
            return semesterMapResult;     
        }
    }
}