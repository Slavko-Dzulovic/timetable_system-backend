using AutoMapper;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Users
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, UserDTO>()
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
					destination => destination.Username,
					options => options.MapFrom(source => source.Username))
				.ForMember(
					destination => destination.Token,
					options => options.MapFrom(source => source.Token));
		}
	}
}