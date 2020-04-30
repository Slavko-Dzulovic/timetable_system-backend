using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots
{
	public class SlotBySemesterAndModuleDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }
		
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}