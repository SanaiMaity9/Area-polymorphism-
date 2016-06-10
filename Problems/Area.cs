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
			double AreaResult = 0.0d;
			AreaResult = System.Math.PI * radiusValue * radiusValue;
			return AreaResult;
		}
	}
		class Square : Shape
	{
		public double Area(int sideValue)
		{
			double AreaResult = 0.0d;
				AreaResult = sideValue * sideValue	;
				return AreaResult;
		}

	}

	public class Area
	{		
		public  void Main()
		{
		
				double AreaResult = 0.0d;
				Circle circleObject = new Circle ();

				AreaResult = circleObject.Area (34);
				Console.WriteLine ("{0}", AreaResult);

			}

	}
}

