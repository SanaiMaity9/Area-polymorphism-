using System;


namespace Problems
{
  interface Shape
	{
		 double Area(int value);
	}

	class Circle : Shape
	{
		public double Area(int radiusValue)
		{
			double Area_Result = 0.0d;
			Area_Result = System.Math.PI * radiusValue * radiusValue;
			return Area_Result;
		}
	}
		class Square : Shape
	{
		public double Area(int sideValue)
		{
			double Area_Result = 0.0d;
				Area_Result = sideValue * sideValue	;
				return Area_Result;
		}

	}

	public class Area
	{		
		public  void Main()
		{
		
				double Area_Result = 0.0d;
				Circle circleObject = new Circle ();

				Area_Result = circleObject.Area (34);
				Console.WriteLine ("{0}", Area_Result);

			}

	}
}

