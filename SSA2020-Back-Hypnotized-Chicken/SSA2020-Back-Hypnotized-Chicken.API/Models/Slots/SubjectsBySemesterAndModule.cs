using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models.Slots
{
	public class SubjectsBySemesterAndModule
	{
		[Required]
		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }
		
		[Required]
		[JsonProperty("module_id")]
		public short ModuleId { get; set; }
	}
}