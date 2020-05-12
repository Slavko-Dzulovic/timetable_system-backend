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
					destination => destination.StartTime,
					options => options.MapFrom(source => source.StartTime.ToString("HH:mm")))
				.ForMember(
					destination => destination.EndTime,
					options => options.MapFrom(source => source.EndTime.ToString("HH:mm")))
				.ForMember(
					destination => destination.Group,
					options => options.MapFrom(source => source.Group))
				.ForMember(
					destination => destination.NumberOfLectures,
					options => options.MapFrom(source => source.NumberOfLectures))
				.ForMember(
					destination => destination.NumberOfExercises,
					options => options.MapFrom(source => source.NumberOfExercises))
				.ForMember(
					destination => destination.NumberOfLabExercises,
					options => options.MapFrom(source => source.NumberOfLabExercises))
				.ForMember(
					destination => destination.IsOptional,
					options => options.MapFrom(source => source.Slot.IsOptional))
				.ForMember(
					destination => destination.OptionalSubjectNumber,
					options => options.MapFrom(source => source.Slot.OptionalSubjectNumber))
				.ForMember(
					destination => destination.ClassroomId,
					options => options.MapFrom(source => source.ClassroomId))
				.ForMember(
					destination => destination.Classroom,
					options => options.MapFrom(source => source.Classroom.Label))
				.ForMember(
					destination => destination.WeekdayId,
					options => options.MapFrom(source => source.WeekdayId))
				.ForMember(
					destination => destination.Weekday,
					options => options.MapFrom(source => source.Weekday.Name))
				.ForMember(
					destination => destination.ScheduleId,
					options => options.MapFrom(source => source.ScheduleId))
				.ForMember(
					destination => destination.SubjectId,
					options => options.MapFrom(source => source.Slot.SubjectId))
				.ForMember(
					destination => destination.Subject,
					options => options.MapFrom(source => source.Slot.Subject.Name))
				.ForMember(
					destination => destination.ModuleId,
					options => options.MapFrom(source => source.Slot.ModuleId))
				.ForMember(
					destination => destination.Module,
					options => options.MapFrom(source => source.Slot.Module.Name))
				.ForMember(
					destination => destination.SemesterId,
					options => options.MapFrom(source => source.Slot.SemesterId))
				.ForMember(
					destination => destination.LecturerId,
					options => options.MapFrom(source => source.Slot.LecturerId))
				.ForMember(
					destination => destination.LecturerFullName,
					options => options.MapFrom(source => source.Slot.Lecturer.Vocation + " " + source.Slot.Lecturer.FirstName + " " + source.Slot.Lecturer.LastName))
				.ForMember(
					destination => destination.SlotId,
					options => options.MapFrom(source => source.SlotId));
		}
	}
}