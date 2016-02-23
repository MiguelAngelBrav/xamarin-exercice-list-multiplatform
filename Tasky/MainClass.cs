using System;
using System.Collections.Generic;

namespace Tasky
{
	public class MainClass
	{
		public MainClass ()
		{
		}
			
		public static List<String> getTaskList()
		{
			//initialize list
			List<String> PhoneNumbers = new List<String> ();
			PhoneNumbers.Add ("Lista 01");
			PhoneNumbers.Add ("Lista 01");
			PhoneNumbers.Add ("Lista 02");
			PhoneNumbers.Add ("Lista 03");

			return PhoneNumbers;
		}
	}
}

