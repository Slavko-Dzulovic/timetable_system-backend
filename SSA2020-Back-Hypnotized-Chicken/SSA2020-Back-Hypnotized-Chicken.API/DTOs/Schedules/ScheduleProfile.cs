using System;
using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Schedules
{
	public class ScheduleProfile : Profile
	{
		private static readonly long DateTimeMinTimeTicks = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks;
		
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
					options => options.MapFrom(source => source.IsActive))
				.ForMember(
					destination => destination.UpdatedAt,
					options => options.MapFrom(source => ToJavaScriptMilliseconds(source.UpdatedAt)))
				.ForMember(
					destination => destination.Semester,
					options => options.MapFrom(source => source.Semester.Name));
		}

		public static long ToJavaScriptMilliseconds(DateTime dateTime)
		{
			return (dateTime.Ticks - DateTimeMinTimeTicks) / 10000;
		}
	}
}