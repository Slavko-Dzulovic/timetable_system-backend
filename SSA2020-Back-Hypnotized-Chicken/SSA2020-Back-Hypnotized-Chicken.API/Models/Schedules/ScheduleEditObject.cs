using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models
{
	public class ScheduleEditObject
	{
		[Required]
		[JsonProperty("id")]
		public short Id { get; set; }
		
		[Required]
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}