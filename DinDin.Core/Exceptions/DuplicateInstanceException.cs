using System;
using System.Collections.Generic;
using System.Text;

namespace DinDin.Core.Exceptions
{
	[Serializable]
	public class DuplicateInstanceException : ApplicationException
	{
		public DuplicateInstanceException(string instanceType, string uniquenessCriteria)
			:
			base(string.Format("Duplicate instance of a{2} {0} according to the {1} property", instanceType, uniquenessCriteria,
			"aeiou".IndexOf(instanceType[0].ToString().ToLower()) >= 0 ? "n" : ""))
		{
		}
	}
}
