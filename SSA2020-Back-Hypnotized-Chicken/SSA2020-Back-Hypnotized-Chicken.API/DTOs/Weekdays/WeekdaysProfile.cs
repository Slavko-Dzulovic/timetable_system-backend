using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Weekdays
{
	public class WeekdaysProfile : Profile
	{
		public WeekdaysProfile()
		{
			CreateMap<Weekday, WeekdayDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.Name,
					options => options.MapFrom(source => source.Name));
		}
	}
}