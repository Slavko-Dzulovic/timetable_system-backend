using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("schedules")]
	public class Schedule : TimestampedEntity<int>
	{
		[Key]
		[Column("id", Order = 0)]
		public override int Id { get; set; }
		
		[Required]
		[Column("department", Order = 1)]
		[MaxLength(255)]
		public string Department { get; set; }
		
		[Required]
		[Column("semester", Order = 2)]
		public short Semester { get; set; }
		
		[Required]
		[Column("year", Order = 3)]
		public string Year { get; set; }
	}
}