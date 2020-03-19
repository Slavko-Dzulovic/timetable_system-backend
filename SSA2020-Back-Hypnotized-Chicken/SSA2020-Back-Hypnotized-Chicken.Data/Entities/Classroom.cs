using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("classrooms")]
	public class Classroom : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("label", Order = 1)]
		[MaxLength(255)]
		public string Label { get; set; }
		
		[Required]
		[Column("location", Order = 2)]
		[MaxLength(255)]
		public string Location { get; set; }
		
		public ICollection<Term> Terms { get; set; }
	}
}