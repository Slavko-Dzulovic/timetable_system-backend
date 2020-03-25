using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Lecturers
{
    public class LecturerProfile : Profile
    {
        public LecturerProfile()
        {
            CreateMap<Lecturer, LecturerDTO>()
                .ForMember(
                    destination => destination.Id,
                    options => options.MapFrom(source => source.Id))
                .ForMember(
                    destination => destination.FirstName,
                    options => options.MapFrom(source => source.FirstName))
                .ForMember(
                    destination => destination.LastName,
                    options => options.MapFrom(source => source.LastName))
                .ForMember(
                    destination => destination.Vocation,
                    options => options.MapFrom(source => source.Vocation));
        }
    }
}