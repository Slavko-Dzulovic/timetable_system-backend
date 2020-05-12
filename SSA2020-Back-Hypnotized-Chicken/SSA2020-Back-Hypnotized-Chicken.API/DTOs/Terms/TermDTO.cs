using Newtonsoft.Json;
using System;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Terms
{
	public class TermDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }

		[JsonProperty("group")]
		public short Group { get; set; }

		[JsonProperty("module")]
		public string Module { get; set; }

		[JsonProperty("number_of_lectures")]
		public short NumberOfLectures { get; set; }

		[JsonProperty("number_of_exercises")]
		public short NumberOfExercises { get; set; }

		[JsonProperty("number_of_lab_exercises")]
		public short NumberOfLabExercises { get; set; }

		[JsonProperty("classroom")]
		public string Classroom { get; set; }

		[JsonProperty("optional_subject_number")]
		public short OptionalSubjectNumber { get; set; }

		[JsonProperty("slot_id")]
		public long SlotId { get; set; }
	}
}