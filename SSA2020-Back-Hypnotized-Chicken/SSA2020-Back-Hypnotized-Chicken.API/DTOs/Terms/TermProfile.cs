using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Terms
{
	public class TermProfile : Profile
	{
		public TermProfile()
		{
			CreateMap<Term, TermDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.Time,
					options => options.MapFrom(source => source.Time))
				.ForMember(
					destination => destination.Group,
					options => options.MapFrom(source => source.Group))
				.ForMember(
					destination => destination.Module,
					options => options.MapFrom(source => source.Module))
				.ForMember(
					destination => destination.OptionalSubjectNumber,
					options => options.MapFrom(source => source.OptionalSubjectNumber))
				.ForMember(
					destination => destination.NumberOfLectures,
					options => options.MapFrom(source => source.NumberOfLectures))
				.ForMember(
					destination => destination.NumberOfExercises,
					options => options.MapFrom(source => source.NumberOfExercises))
				.ForMember(
					destination => destination.NumberOfLabExercises,
					options => options.MapFrom(source => source.NumberOfLabExercises));
		}
	}
}