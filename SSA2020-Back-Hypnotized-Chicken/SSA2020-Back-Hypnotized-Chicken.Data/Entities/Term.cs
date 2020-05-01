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
		[Column("time", Order = 1)]
		public DateTime Time { get; set; }

		[Column("group", Order = 2)]
		public short Group { get; set; }
		
		[Column("module", Order = 3)]
		public string Module { get; set; }
		
		[Column("optional_subject_number", Order = 4)]
		public short OptionalSubjectNumber { get; set; }
		
		[Column("number_of_lectures", Order = 5)]
		public short NumberOfLectures { get; set; }

		[Column("number_of_exercises", Order = 6)]
		public short NumberOfExercises { get; set; }
		
		[Column("number_of_lab_exercises", Order = 7)]
		public short NumberOfLabExercises { get; set; }
		
		[Required]
		[Column("weekday_id", Order = 8)]
		public short WeekdayId { get; set; }
		
		[ForeignKey("WeekdayId")]
		public Weekday Weekday { get; set; }
		
		[Required]
		[Column("classroom_id", Order = 9)]
		public short ClassroomId { get; set; }

		[ForeignKey("ClassroomId")]
		public Classroom Classroom { get; set; }
		
		[Column("schedule_id", Order = 10)]
		public short ScheduleId { get; set; }
		
		[ForeignKey("ScheduleId")]
		public Schedule Schedule { get; set; }
		
		[Column("slot_id", Order = 10)]
		public long SlotId { get; set; }
		
		[ForeignKey("SlotId")]
		public Slot Slot { get; set; }
	}
}