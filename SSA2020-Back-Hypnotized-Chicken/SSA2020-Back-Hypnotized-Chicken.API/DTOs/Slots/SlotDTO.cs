using Newtonsoft.Json;

namespace SSA2020_Back_Hypnotized_Chicken.API.DTOs.Slots
{
	public class SlotDTO
	{
		[JsonProperty("id")]
		public short Id { get; set; }

		[JsonProperty("subject_id")]
		public short SubjectId { get; set; }

		[JsonProperty("module_id")]
		public short ModuleId { get; set; }

		[JsonProperty("semester_id")]
		public short SemesterId { get; set; }

		[JsonProperty("lecturer_id")]
		public short LecturerId { get; set; }
	}
}