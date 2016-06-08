using System;

namespace hello_world
{
	public class char_occurancy
	{
		
		public   void Main()
		{
			//int count = 0;
			string input;
			Console.WriteLine ("enter the string ");
			input = Console.ReadLine();

			//converting string to array
			char[] array = input.ToCharArray ();

			//converting char to lower case
			for(int x=0;x<array.Length;x++){
			
				array [x] = char.ToLower (array [x]);
			}
		
			int[] count = new int[26];
			char ch = (char)97;

			for (int i = 0; i <array.Length; i++)
			{
				for(int j=0;j<26;j++)
				{
					if (array[i] == (ch+j))
					{
						count[j]++;
					}
				}
			}
			for(int j=0;j<26;j++)
			{

				Console.WriteLine("\n{0} -> {1}",Convert.ToChar(97+j),count[j]);

			}


				
	
		}
	}
}

