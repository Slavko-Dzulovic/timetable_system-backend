using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	public enum ClassroomSeed : short
	{
		u21 = 1,
		u15 = 2,
		u17 = 3,
		u16 = 4,
		u212 = 5,
		u214 = 6,
		u215 = 7,
		u217 = 8,
		u218 = 9
	}
	
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
		
		[Column("location", Order = 2)]
		[MaxLength(255)]
		public string Location { get; set; }
		
		public ICollection<Term> Terms { get; set; }
	}
}