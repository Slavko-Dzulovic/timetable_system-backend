using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Users
{
	public class UserDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }
	}
}