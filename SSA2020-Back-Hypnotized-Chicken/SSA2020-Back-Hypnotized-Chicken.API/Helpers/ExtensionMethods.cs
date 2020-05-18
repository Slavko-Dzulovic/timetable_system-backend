using System.Collections.Generic;
using System.Linq;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.API.Helpers
{
	public static class ExtensionMethods
	{
        public static List<User> WithoutPasswords(this IEnumerable<User> users)
        {
	        return (List<User>) users?.Select(u => u.WithoutPassword());
        }

        public static User WithoutPassword(this User user) 
        {
	        if (user == null)
	        {
		        return null;
	        }

            user.Password = null;
            return user;
        }
	}
}