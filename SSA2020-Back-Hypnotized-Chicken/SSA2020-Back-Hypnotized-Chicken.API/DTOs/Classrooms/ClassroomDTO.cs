using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Classrooms
{
    public class ClassroomDTO
    {
        [JsonProperty("id")]
        public short Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}