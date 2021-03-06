﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models.Terms
{
	public class TermEditObject
	{
		[Required]
		[JsonProperty("id")]
		public short Id { get; set; }

		[Required]
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		[Required]
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

		[Required]
		[JsonProperty("weekday_id")]
		public short WeekdayId { get; set; }

		[Required]
		[JsonProperty("classroom_id")]
		public short ClassroomId { get; set; }

		[JsonProperty("schedule_id")]
		public short ScheduleId { get; set; }

		[Required]
		[JsonProperty("subject_id")]
		public short SubjectId { get; set; }

		[Required]
		[JsonProperty("module_id")]
		public short ModuleId { get; set; }

		[Required]
		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }

		[Required]
		[JsonProperty("lecturer_id")]
		public short LecturerId { get; set; }
	}
}