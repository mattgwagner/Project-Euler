using System;
using System.Collections.Generic;
using System.Text;

public class MyClass
{
	public static void Main()
	{
		int count = 0;
		
		DateTime d = new DateTime(1901, 1, 1);
		DateTime end = new DateTime(2000,12,31);
		
		while(d < end)
		{
			if(d.DayOfWeek == DayOfWeek.Sunday)
				count++;
			
			d = d.AddMonths(1);
		}
		
		Console.WriteLine(count);
	}
}