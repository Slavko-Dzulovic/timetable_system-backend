using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs;
using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Classrooms;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassroomsController : BaseController<ClassroomsController>
    {
        public ClassroomsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        [HttpGet]
        public async Task<ActionResult<List<ClassroomDTO>>> Get()
        {
            var classrooms = await UnitOfWork.ClassroomsRepository.GetClassroomsAsync();

            if (classrooms == null || !classrooms.Any())
            {
                return NoContent();
            }

            var classroomMapResult = Mapper.Map<List<Classroom>, List<ClassroomDTO>>(classrooms);

            return Ok(classroomMapResult);
        }
    }
}