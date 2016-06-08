using System;

namespace Problems
{
	class Arithmatic{
	public double add(int a,int b){
			int c = 0 ;
			c = a+b;
			return c;
		}
	
	}
	public class Addition
	{
		public static void Main(){
			Arithmatic obj = new Arithmatic ();

			Console.WriteLine ("{0}", obj.add (24, 45));
		}
	}
}

