using System;

namespace hello_world
{
	public class CharacterOccurancy
	{
		
		public  void Main ()
		{
			//int count = 0;
			string input_Character;
			Console.WriteLine ("Enter the string");
			input_Character = Console.ReadLine();

			//converting string to array
			char[] char_Array = input_Character.ToCharArray ();

			//converting char to lower case
			for (int x = 0; x < char_Array.Length; x++)
			{
			
				char_Array [x] = char.ToLower (char_Array [x]);
			}
		
			int[] count = new int[26];
			char ascii_Char = (char)97;

			for (int i = 0; i < char_Array.Length; i++)
			{
				for(int j = 0; j < 26; j++)
				{
					if (char_Array[i] == (ascii_Char + j))
					{
						count[j]++;
					}
				}
			}
			for(int j = 0; j < 26; j++)
			{

				Console.WriteLine("\n{0} -> {1}",Convert.ToChar(97 + j), count[j]);

			}

		}
	}
}

