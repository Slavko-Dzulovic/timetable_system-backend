using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Departments
{
    public class DepartmentDTO
    {
        [JsonProperty("id")]
        public short Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}