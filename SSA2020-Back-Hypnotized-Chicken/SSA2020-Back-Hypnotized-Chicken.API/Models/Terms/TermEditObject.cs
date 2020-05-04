using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models
{
	public class TermEditObject
	{
		[Required]
		[JsonProperty("id")]
		public short Id { get; set; }

		[Required]
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		[Required]
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

		[Required]
		[JsonProperty("weekday_id")]
		public short WeekdayId { get; set; }
		[Required]
		[JsonProperty("classroom_id")]
		public short ClassroomId { get; set; }
	}
}