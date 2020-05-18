using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models.Users
{
	public class UserLoginModel
	{
		[Required]
		[JsonProperty("username")]
		public string Username { get; set; }

		[Required]
		[JsonProperty("password")]
		public string Password { get; set; }
	}
}