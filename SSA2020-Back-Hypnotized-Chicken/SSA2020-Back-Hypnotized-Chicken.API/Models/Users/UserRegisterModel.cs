using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.Models.Users
{
    public class UserRegisterModel
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
        
        [Required]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}