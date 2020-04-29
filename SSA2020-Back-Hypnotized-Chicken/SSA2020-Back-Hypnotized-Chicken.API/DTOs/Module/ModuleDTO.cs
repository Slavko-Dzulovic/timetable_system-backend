using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Modules
{
    public class ModuleDTO
    {
        [JsonProperty("id")]
        public short Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}