using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Semesters
{
    public class SemesterProfile : Profile
    {
        public SemesterProfile()
        {
            CreateMap<Semester, SemesterDTO>()
                .ForMember(
                    destination => destination.Id,
                    options => options.MapFrom(source => source.Id))
                .ForMember(
                    destination => destination.Name,
                    options => options.MapFrom(source => source.Name));
        }
    }
}