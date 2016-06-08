using System;

namespace Problems
{
	class ArithmaticCalculaion
	{
	public double Add(int a,int b)
		{
			int c = 0 ;
			c = a + b;
			return c;
		}
	
	}
	public class Addition
	{
		public static void Main()
		{
			ArithmaticCalculaion obj = new ArithmaticCalculaion ();

			Console.WriteLine ("{0}", obj.Add(24, 45));
		}
	}
}

