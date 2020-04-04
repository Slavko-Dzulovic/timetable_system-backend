using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("module_subjects")]
	public class ModuleSubject : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("module_id", Order = 1)]
		public  short ModuleId { get; set; }
		
		[ForeignKey("ModuleId")]
		public Module Module { get; set; }

		[Required]
		[Column("subject_id", Order = 2)]
		public short SubjectId { get; set; }
		
		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
		
		[Required]
		[Column("is_optional", Order = 3)]
		public bool IsOptional { get; set; }
	}
}