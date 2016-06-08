using System;

 namespace hello_world
{
	public class DeleteCharacter
	{
		public  void Main()
	 {
			string input_String;
			Console.WriteLine ("Enter the string ");
			input_String = Console.ReadLine ();
			char[] char_Array = input_String.ToCharArray();
			Console.WriteLine ("Enter the char to delete");
			char char_Delete = Console.ReadKey ().KeyChar;

			for (int i = 0; i < char_Array.Length; i++)
			{
			        int j = i;
					if (char_Array [i] == char_Delete)
				{
					while (j < char_Array.Length - 1)
					{
						char_Array [j] = char_Array [j + 1];
						char_Array [j + 1] = ' ';
						j++;
					}
				}
			}

			Console.WriteLine ("\n");
			Console.WriteLine (char_Array);
	}
   }
}

