using System;
using System.Collections.Generic;

namespace Tasky_list
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
			PhoneNumbers.Add ("Tarea 01");
			PhoneNumbers.Add ("Tarea 02");
			PhoneNumbers.Add ("Tarea 03");
			PhoneNumbers.Add ("Tarea 04");

			return PhoneNumbers;
		}
	}
}

