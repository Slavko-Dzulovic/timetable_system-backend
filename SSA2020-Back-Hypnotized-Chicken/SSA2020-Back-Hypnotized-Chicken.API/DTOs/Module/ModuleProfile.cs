using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Modules
{
    public class ModuleProfile : Profile
    {
        public ModuleProfile()
        {
            CreateMap<Module, ModuleDTO>()
                .ForMember(
                    destination => destination.Id,
                    options => options.MapFrom(source => source.Id))
                .ForMember(
                    destination => destination.Name,
                    options => options.MapFrom(source => source.Name));
        }
    }
}