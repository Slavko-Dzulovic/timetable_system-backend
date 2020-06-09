using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Models.Subjects;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Subjects
{
	public class SubjectProfile : Profile
	{
		public SubjectProfile()
		{
			CreateMap<Subject, SubjectDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.Name,
					options => options.MapFrom(source => source.Name));
			CreateMap<SubjectWithIsOptional, SubjectDTO>()
				.ForMember(
					destination => destination.Id,
					options => options.MapFrom(source => source.Id))
				.ForMember(
					destination => destination.Name,
					options => options.MapFrom(source => source.Name))
				.ForMember(
					destination => destination.IsOptional,
					options => options.MapFrom(source => source.IsOptional));
		}
	}
}