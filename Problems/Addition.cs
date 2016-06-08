using System;

namespace Problems
{
	class ArithmaticCalculaion
	{
	public double Add(int firstNumber,int secondNumber)
		{
			int sum = 0 ;
			sum = firstNumber + secondNumber;
			return sum;
		}
	
	}
	public class Addition
	{
		public static void Main()
		{
			ArithmaticCalculaion obj = new ArithmaticCalculaion();

			Console.WriteLine ("{0}", obj.Add(24, 45));
		}
	}
}

