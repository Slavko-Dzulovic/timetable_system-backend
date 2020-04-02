using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("semester_subjects")]
	public class SemesterSubject : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("semester_id", Order = 1)]
		public short SemesterId { get; set; }

		[ForeignKey("SemesterId")]
		public Semester Semester { get; set; }
		
		[Required]
		[Column("subject_id", Order = 2)]
		public short SubjectId { get; set; }
		
		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
	}
}