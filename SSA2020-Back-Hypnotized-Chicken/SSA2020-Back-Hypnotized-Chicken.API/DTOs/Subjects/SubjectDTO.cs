using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Subjects
{
	public class SubjectDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }
		
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("is_optional")]
		public bool IsOptional { get; set; }
	}
}