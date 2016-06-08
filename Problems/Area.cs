using System;


namespace Problems
{
  interface Shape{
		 double area(int a);
	}

	class Circle : Shape{
		public double area(int r){
			double result = 0.0d;
			result = System.Math.PI * r * r;
			return result;
		}
	}
		class Square : Shape{
		public double area(int a){
				double result = 0.0d;
				result = a * a;
				return result;
		}

	}

	public class Area
	{		
		public  void Main(){
		
				double answer = 0.0d;
				Circle obj = new Circle ();

				answer = obj.area (34);
				Console.WriteLine ("{0}", answer);

			}

	}
}

