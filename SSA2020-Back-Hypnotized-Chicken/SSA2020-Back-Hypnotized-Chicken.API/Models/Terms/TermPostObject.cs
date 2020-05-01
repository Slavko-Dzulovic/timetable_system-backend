using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models
{
	public class TermPostObject
	{
		[Required]
		[JsonProperty("time")]
		public DateTime Time { get; set; }

		[JsonProperty("group")]
		public short Group { get; set; }

		[JsonProperty("module")]
		public string Module { get; set; }

		[JsonProperty("optional_subject_number")]
		public short OptionalSubjectNumber { get; set; }

		[JsonProperty("number_of_lectures")]
		public short NumberOfLectures { get; set; }

		[JsonProperty("number_of_exercises")]
		public short NumberOfExercises { get; set; }

		[JsonProperty("number_of_lab_exercises")]
		public short NumberOfLabExercises { get; set; }

		[Required]
		[JsonProperty("weekday_id")]
		public short WeekdayId { get; set; }
		[Required]
		[JsonProperty("classroom_id")]
		public short ClassroomId { get; set; }

		[JsonProperty("schedule_id")]
		public short ScheduleId { get; set; }

		[JsonProperty("slot_id")]
		public long SlotId { get; set; }
	}
}