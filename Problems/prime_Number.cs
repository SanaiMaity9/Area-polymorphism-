using System;

namespace Application
{
	public class prime_Number
	{
		public prime_Number ()
		{
			int i, j, count = 0;
			for (i=0; i<=50; i++) {
				i = 0;
				for (j=0; j<=i; j++) {
					if (i % j == 0) {
						count++;
						break;

					}
				}
				if (count == 2) {
					Console.WriteLine ("{0}", i);

				}
			}

		}
	}
}

