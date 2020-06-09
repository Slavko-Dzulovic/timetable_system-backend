using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	public enum Modules : short
	{
		None = 0,
		SI = 1,
		ITI = 2,
		ITO = 3,
		RI = 4,
		IEE = 5,
		EES = 6,
		PM = 7,
		IM = 8,
		TI = 9,
		MEH = 10
	}
	
	[Table("modules")]
	public class Module : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("name", Order = 1)]
		[MaxLength(255)]
		public string Name { get; set; }
		
		[Column("department_id", Order = 2)]
		public short DepartmentId { get; set; }
		
		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }
		
		public ICollection<Slot> Slots { get; set; }
	}
}