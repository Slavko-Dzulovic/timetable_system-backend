using Newtonsoft.Json;
using System;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Terms
{
	public class TermDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		[JsonProperty("group")]
		public short Group { get; set; }

		[JsonProperty("number_of_lectures")]
		public short NumberOfLectures { get; set; }

		[JsonProperty("number_of_exercises")]
		public short NumberOfExercises { get; set; }

		[JsonProperty("number_of_lab_exercises")]
		public short NumberOfLabExercises { get; set; }

		[JsonProperty("is_optional")]
		public bool IsOptional { get; set; }

		[JsonProperty("optional_subject_number")]
		public short OptionalSubjectNumber { get; set; }

		[JsonProperty("classroom_id")]
		public short ClassroomId { get; set; }

		[JsonProperty("classroom")]
		public string Classroom { get; set; }

		[JsonProperty("weekday_id")]
		public short WeekdayId { get; set; }

		[JsonProperty("weekday")]
		public string Weekday { get; set; }

		[JsonProperty("schedule_id")]
		public short ScheduleId { get; set; }

		[JsonProperty("subject_id")]
		public short SubjectId { get; set; }

		[JsonProperty("subject")]
		public string Subject { get; set; }

		[JsonProperty("module_id")]
		public short ModuleId { get; set; }

		[JsonProperty("module")]
		public string Module { get; set; }

		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }

		[JsonProperty("lecturer_id")]
		public short LecturerId { get; set; }

		[JsonProperty("lecturer_full_name")]
		public string LecturerFullName { get; set; }

		[JsonProperty("slot_id")]
		public long SlotId { get; set; }
	}
}