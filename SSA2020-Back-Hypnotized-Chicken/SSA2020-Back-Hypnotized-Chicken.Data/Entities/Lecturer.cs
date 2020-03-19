using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("lecturers")]
	public class Lecturer : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("first_name", Order = 3)]
		[MaxLength(255)]
		public string FirstName { get; set; }

		[Required]
		[Column("last_name", Order = 4)]
		[MaxLength(255)]
		public string LastName { get; set; }
		
		[Column("vocation", Order = 5)]
		[MaxLength(255)]
		public string Vocation { get; set; }

		[Required]
		[Column("subject_id", Order = 6)]
		public short SubjectId { get; set; }

		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
	}
}