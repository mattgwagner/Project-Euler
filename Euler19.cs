using System;
using System.Collections.Generic;
using System.Text;

public class MyClass
{
	public static void RunSnippet()
	{
		int count = 0;
		DateTime d = new DateTime(1901, 1, 1);
		DateTime end = new DateTime(2000,12,31);
		
		while(d < end)
		{
            Console.WriteLine(d.ToShortDateString());

			if(d.DayOfWeek == DayOfWeek.Sunday)
				count++;
			
			d = d.AddMonths(1);
		}
		
		WL(count);
	}
	
	#region Helper methods
	
	public static void Main()
	{
		try
		{
			RunSnippet();
		}
		catch (Exception e)
		{
			string error = string.Format("---\nThe following error occurred while executing the snippet:\n{0}\n---", e.ToString());
			Console.WriteLine(error);
		}
		finally
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}

	private static void WL(object text, params object[] args)
	{
		Console.WriteLine(text.ToString(), args);	
	}
	
	private static void RL()
	{
		Console.ReadLine();	
	}
	
	private static void Break() 
	{
		System.Diagnostics.Debugger.Break();
	}

	#endregion
}