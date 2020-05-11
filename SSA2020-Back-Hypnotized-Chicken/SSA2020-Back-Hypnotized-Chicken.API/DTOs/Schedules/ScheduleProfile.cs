using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Schedules
{
	public class ScheduleProfile : Profile
	{
		public ScheduleProfile()
		{
			CreateMap<Schedule, ScheduleDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.Name,
					options => options.MapFrom(source => source.Name))
				.ForMember(
					destination => destination.SemesterId,
					options => options.MapFrom(source => source.SemesterId))
				.ForMember(
					destination => destination.DepartmentId,
					options => options.MapFrom(source => source.DepartmentId))
				.ForMember(
					destination => destination.IsActive,
					options => options.MapFrom(source => source.IsActive));
		}
	}
}