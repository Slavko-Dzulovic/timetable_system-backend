using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models
{
	public class SchedulePostObject
	{
		[Required]
		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }
		
		[Required]
		[JsonProperty("department_id")]
		public short DepartmentId { get; set; }
	}
}