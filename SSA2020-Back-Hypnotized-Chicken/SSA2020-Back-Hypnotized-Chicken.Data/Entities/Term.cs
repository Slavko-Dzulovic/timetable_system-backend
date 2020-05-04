using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("terms")]
	public class Term : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }

		[Required]
		[Column("startTime", Order = 1)]
		public DateTime StartTime { get; set; }

		[Required]
		[Column("endTime", Order = 2)]
		public DateTime EndTime { get; set; }

		[Column("group", Order = 3)]
		public short Group { get; set; }
		
		[Column("module", Order = 4)]
		public string Module { get; set; }

		[Column("numberOfLectures", Order = 5)]
		public short NumberOfLectures { get; set; }

		[Column("numberOfExercises", Order = 6)]
		public short NumberOfExercises { get; set; }
		
		[Column("numberOfLabExercises", Order = 7)]
		public short NumberOfLabExercises { get; set; }
		
		[Required]
		[Column("weekdayId", Order = 8)]
		public short WeekdayId { get; set; }
		
		[ForeignKey("WeekdayId")]
		public Weekday Weekday { get; set; }
		
		[Required]
		[Column("classroomId", Order = 9)]
		public short ClassroomId { get; set; }
		
		[ForeignKey("ClassroomId")]
		public Classroom Classroom { get; set; }
		
		[Required]
		[Column("scheduleId", Order = 10)]
		public short ScheduleId { get; set; }
		
		[ForeignKey("ScheduleId")]
		public Schedule Schedule { get; set; }
		
		[Required]
		[Column("slotId", Order = 11)]
		public long SlotId { get; set; }
		
		[ForeignKey("SlotId")]
		public Slot Slot { get; set; }
	}
}