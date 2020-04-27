using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	public enum ClassroomSeed : short
	{
		[Display(Name = "Amfiteatar")]
		u21 = 1,
		
		[Display(Name = "15")]
		u15 = 2,
		
		[Display(Name = "17")]
		u17 = 3,
		
		[Display(Name = "16")]
		u16 = 4,
		
		[Display(Name = "212")]
		u212 = 5,
		
		[Display(Name = "214")]
		u214 = 6,
		
		[Display(Name = "215")]
		u215 = 7,
		
		[Display(Name = "217")]
		u217 = 8,
		
		[Display(Name = "218")]
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