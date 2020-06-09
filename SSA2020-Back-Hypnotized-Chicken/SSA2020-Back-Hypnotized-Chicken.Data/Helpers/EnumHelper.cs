using System;
using System.Linq;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Helpers
{
	public class EnumHelper
	{
        public static T GetAttributeValue<T>(Enum enumValue) where T : Attribute
        {
            return enumValue.GetType().GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(T), false)
                .Cast<T>().FirstOrDefault();
        }
	}
}