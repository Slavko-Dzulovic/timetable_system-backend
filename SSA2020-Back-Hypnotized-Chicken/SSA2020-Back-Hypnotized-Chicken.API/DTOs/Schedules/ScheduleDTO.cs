using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Schedules
{
	public class ScheduleDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}