using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("subjects")]
	public class Subject : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("name", Order = 1)]
		[MaxLength(255)]
		public string Name { get; set; }

		public ICollection<Lecturer> Lecturers { get; set; }
		
		public ICollection<Term> Terms { get; set; }
	}
}