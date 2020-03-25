using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Classrooms
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<Classroom, ClassroomDTO>()
                .ForMember(
                    destination => destination.Id,
                    options => options.MapFrom(source => source.Id))
                .ForMember(
                    destination => destination.Label,
                    options => options.MapFrom(source => source.Label))
                .ForMember(
                    destination => destination.Location,
                    options => options.MapFrom(source => source.Location));
        }
    }
}