using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	public enum Departments : short
	{
		IT = 1,
		IM = 2,
		ERI = 3,
		TI = 4,
		PM = 5,
		MEH = 6
	}
	
	[Table("departments")]
	public class Department : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("name", Order = 1)]
		[MaxLength(255)]
		public string Name { get; set; }
		
		public ICollection<Schedule> Schedules { get; set; }
		public ICollection<Module> Modules { get; set; }
	}
}