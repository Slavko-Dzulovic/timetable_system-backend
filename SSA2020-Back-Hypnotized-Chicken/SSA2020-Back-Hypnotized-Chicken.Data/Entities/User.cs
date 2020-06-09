using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Entities
{
	public static class Role
	{
		public const string Admin = "Admin";
		public const string User = "User";
	}
	
	[Table("users")]
	public class User : TimestampedEntity<short>
	{
		[Key]
		[Column("id", Order = 0)]
		public override short Id { get; set; }
		
		[Required]
		[Column("first_name", Order = 1)]
		[MaxLength(255)]
		public string FirstName { get; set; }

		[Required]
		[Column("last_name", Order = 2)]
		[MaxLength(255)]
		public string LastName { get; set; }

		[Required]
		[Column("username", Order = 3)]
		[MaxLength(255)]
		public string Username { get; set; }

		[Required]
		[Column("password_hash", Order = 4)]
		[MaxLength(255)]
		public byte[] PasswordHash { get; set; }
		
		[Required]
		[Column("password_salt", Order = 5)]
		[MaxLength(255)]
		public byte[] PasswordSalt { get; set; }

		[Required]
		[Column("role", Order = 6)]
		[MaxLength(255)]
		public string Role { get; set; }
		
		[Required]
		[Column("token", Order = 7)]
		[MaxLength(255)]
		public string Token { get; set; }
	}
}