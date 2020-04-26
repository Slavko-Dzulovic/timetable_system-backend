using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("slots")]
	public class Slot : TimestampedEntity<long>
	{
		[Key]
		[Column("id", Order = 0)]
		public override long Id { get; set; }
		
		[Required]
		[Column("subject_id", Order = 1)]
		public short SubjectId { get; set; }
		
		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
		
		[Required]
		[Column("module_id", Order = 2)]
		public short ModuleId { get; set; }
		
		[ForeignKey("ModuleId")]
		public Module Module { get; set; }
		
		[Required]
		[Column("semester_id", Order = 3)]
		public short SemesterId { get; set; }
		
		[ForeignKey("SemesterId")]
		public Semester Semester { get; set; }
		
		[Required]
		[Column("lecturer_id", Order = 4)]
		public short LecturerId { get; set; }
		
		[ForeignKey("LecturerId")]
		public Lecturer Lecturer { get; set; }
		
		[Required]
		[Column("is_optional", Order = 5)]
		public bool IsOptional { get; set; }
		
		public ICollection<Term> Terms { get; set; }
	}
}