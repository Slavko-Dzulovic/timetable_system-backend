using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots
{
	public class SlotProfile : Profile
	{
		public SlotProfile()
		{
			CreateMap<Slot, SlotDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.SubjectId,
					options => options.MapFrom(source => source.SubjectId))
				.ForMember(
					destination => destination.ModuleId,
					options => options.MapFrom(source => source.ModuleId))
				.ForMember(
					destination => destination.SemesterId,
					options => options.MapFrom(source => source.SemesterId))
				.ForMember(
					destination => destination.LecturerId,
					options => options.MapFrom(source => source.LecturerId))
				.ForMember(
					destination => destination.IsOptional,
					options => options.MapFrom(source => source.IsOptional));

		}
	}
}