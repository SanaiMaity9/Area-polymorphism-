using System;

namespace Application
{
	public class PrimeNumber
	{
		public void Main()
		{
			int i, j;
			bool isPrime = true;

			for (i = 2; i<=50; i++) 
			{
				//i = 1;
				for (j = 2; j<=50; j++)
				{
					if (i != j && i % j == 0)
					{
						isPrime = false;
						break;

					}
				}
				if (isPrime)
				{
					Console.WriteLine ("{0}", i);

				}
				isPrime = true;
			}

		}
	}
}

