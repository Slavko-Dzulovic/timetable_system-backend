using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using SSA2020_Back_Hypnotized_Chicken.API.DTOs.Modules;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.UnitOfWork;

namespace SSA2020_Back_Hypnotized_Chicken.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModulesController : BaseController<ModulesController>
    {
        public ModulesController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork) { }

        [HttpGet]
        public async Task<ActionResult<List<ModuleDTO>>> Get()
        {
            var modules = await UnitOfWork.ModulesRepository.GetModulesAsync();

            if (modules == null || !modules.Any())
            {
                return NoContent();
            }

            var moduleMapResult = Mapper.Map<List<Module>, List<ModuleDTO>>(modules);

            return Ok(moduleMapResult);
        }

        [HttpGet("by_department")]
        public async Task<ActionResult<List<ModuleDTO>>> Get([FromQuery] short departmentId)
        {
            var validateDepartmentId = await UnitOfWork.DepartmentsRepository.CheckIfDepartmentExistsAsync(departmentId);

            if (!validateDepartmentId)
            {
                return BadRequest("No department by the given id exists.");
            }

            var modules = await UnitOfWork.ModulesRepository.GetModulesByDepartmentAsync(departmentId);
            if (modules == null ||
                !modules.Any())
            {
                return NoContent();
            }

            var moduleMapResult = Mapper.Map<List<Module>, List<ModuleDTO>>(modules);

            return Ok(moduleMapResult);
        }

        [HttpGet("{id}")]
        public ModuleDTO GetById(int id)
        {
            var module = UnitOfWork.ModulesRepository.GetModuleById(id);

            var moduleMapResult = Mapper.Map<Module, ModuleDTO>(module);
            return moduleMapResult;
        }
    }
}