using System;

namespace hello_world
{
	public class DublicateCharacter
	{
		public void Main()
		{
			int count = 0;
			string input_String;
			Console.WriteLine ("Enter the string ");
			input_String = Console.ReadLine ();
			char[] char_Array = input_String.ToCharArray ();

			for (int i = 0; i < char_Array.Length; i++) 
			{
				count = 0;
				for (int j = 0; j < char_Array.Length - 1; j++)
				{
					if (i == j) 
					{
						j++;
					}
					if (char_Array [i] == char_Array [j]) 
					{
						count++;
					}
				}
				if (count >= 1  )
				{
					Console.WriteLine ("the char {0} = {1}",char_Array[i], count + 1);
					i++;
				}

			}

		}
	}
}

