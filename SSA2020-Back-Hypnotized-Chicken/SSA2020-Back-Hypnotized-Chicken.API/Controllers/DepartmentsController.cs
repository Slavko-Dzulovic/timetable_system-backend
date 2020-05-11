using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Departments;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : BaseController<DepartmentsController>
    {
        public DepartmentsController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        [HttpGet]
        public async Task<ActionResult<List<DepartmentDTO>>> Get()
        {
            var departments = await UnitOfWork.DepartmentsRepository.GetDepartmentsAsync();

            if (departments == null || !departments.Any())
            {
                return NoContent();
            }

            var departmentMapResult = Mapper.Map<List<Department>, List<DepartmentDTO>>(departments);

            return Ok(departmentMapResult);
        }
        [HttpGet("{id}")]
        public DepartmentDTO GetById(short id)
        {
            var department = UnitOfWork.DepartmentsRepository.GetDepartmentById(id);

            var departmentMapResult = Mapper.Map<Department, DepartmentDTO>(department);
            return departmentMapResult;
        }

    }
}