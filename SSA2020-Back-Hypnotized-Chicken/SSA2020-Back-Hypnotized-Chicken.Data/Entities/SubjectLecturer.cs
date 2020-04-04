using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("subject_lecturers")]
	public class SubjectLecturer : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }

		[Required]
		[Column("lecturer_id", Order = 1)]
		public short LecturerId { get; set; }
		
		[ForeignKey("LecturerId")]
		public Lecturer Lecturer { get; set; }
		
		[Required]
		[Column("subject_id", Order = 2)]
		public short SubjectId { get; set; }
		
		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
	}
}