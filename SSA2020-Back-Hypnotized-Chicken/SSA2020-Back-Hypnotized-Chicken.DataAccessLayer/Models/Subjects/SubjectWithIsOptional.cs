namespace SSA2020_Back_Hypnotized_Chicken.DataAccessLayer.Models.Subjects
{
	public class SubjectWithIsOptional
	{
		public short Id { get; set; }
		
		public string Name { get; set; }

		public bool IsOptional { get; set; }
	}
}