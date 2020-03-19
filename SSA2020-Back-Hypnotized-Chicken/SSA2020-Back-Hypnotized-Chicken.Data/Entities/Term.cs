using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	[Table("classrooms")]
	public class Term : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("weekday", Order = 1)]
		[MaxLength(255)]
		public string Weekday { get; set; }

		[Required]
		[Column("time", Order = 2)]
		[MaxLength(255)]
		public string Time { get; set; }

		[Column("number_of_lectures", Order = 3)]
		public short NumberOfLectures { get; set; }

		[Column("number_of_exercises", Order = 4)]
		public short NumberOfExercises { get; set; }
		
		[Column("number_of_lab_exercises", Order = 5)]
		public short NumberOfLabExercises { get; set; }

		[Column("group", Order = 6)]
		public short Group { get; set; }
		
		[Column("module", Order = 7)]
		public string Module { get; set; }
		
		[Required]
		[Column("subject_id", Order = 8)]
		public short SubjectId { get; set; }

		[ForeignKey("SubjectId")]
		public Subject Subject { get; set; }
		
		[Required]
		[Column("classroom_id", Order = 9)]
		public short ClassroomId { get; set; }

		[ForeignKey("ClassroomId")]
		public Classroom Classroom { get; set; }
		
		[Required]
		[Column("schedule_id", Order = 10)]
		public short ScheduleId { get; set; }

		[ForeignKey("ScheduleId")]
		public Schedule Schedule { get; set; }
	}
}