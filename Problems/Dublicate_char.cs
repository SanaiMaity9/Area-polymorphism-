using System;

namespace hello_world
{
	public class Dublicate_char
	{
		public void Main()
		{
			int count = 0;
			string input;
			Console.WriteLine ("enter the string ");
			input = Console.ReadLine ();
			char[] array = input.ToCharArray ();

			for(int i=0;i<array.Length;i++){
				count = 0;
				for(int j=0;j<array.Length-1;j++){
					if (i == j) {
						j++;
					}
					if (array [i] == array [j]) {
						count++;
					}
				}
				if (count >= 1  ) {
					Console.WriteLine ("the char {0} = {1}",array[i],count+1);
					i++;
				}

			}

		}
	}
}

