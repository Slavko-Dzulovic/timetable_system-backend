using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Departments
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDTO>()
                .ForMember(
                    destination => destination.Id,
                    options => options.MapFrom(source => source.Id))
                .ForMember(
                    destination => destination.Name,
                    options => options.MapFrom(source => source.Name));
        }
    }
}