using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("schedules")]
	public class Schedule : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("name", Order = 1)]
		public string Name { get; set; }
		
		[Required]
		[Column("semester_id", Order = 2)]
		public short SemesterId { get; set; }
		
		[ForeignKey("SemesterId")]
		public Semester Semester { get; set; }
		
		[Required]
		[Column("department_id", Order = 3)]
		public short DepartmentId { get; set; }
		
		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

		public ICollection<Term> Terms { get; set; }
	}
}