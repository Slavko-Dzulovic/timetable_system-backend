﻿using System;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Schedules
{
	public class ScheduleDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
		
		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }

		[JsonProperty("department_id")]
		public short DepartmentId { get; set; }
		
		[JsonProperty("is_active")]
		public bool IsActive { get; set; }
		
		[JsonProperty("created_at")]
		public long CreatedAt { get; set; }
		
		[JsonProperty("updated_at")]
		public long UpdatedAt { get; set; }
		
		[JsonProperty("semester")]
		public string Semester { get; set; }
		
		[JsonProperty("department")]
		public string Department { get; set; }
	}
}