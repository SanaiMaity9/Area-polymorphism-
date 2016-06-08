using System;

 namespace hello_world
{
	public class Del_Char
	{
		public  void Main()
	 {
			string input;
			//char[] a = new char[1000];
			Console.WriteLine ("enter the string ");
			input = Console.ReadLine ();
			char[] array = input.ToCharArray();
			//Console.WriteLine (array);
			Console.WriteLine ("enter the char to delete");
			char del = Console.ReadKey ().KeyChar;


			for (int i = 0; i < array.Length; i++)
			{
			int j = i;
					if (array [i] == del) {
					while(j<array.Length-1){
						array [j] = array [j + 1];
						array[j+1] = ' ';
						j++;
					}
				}
			}
			Console.WriteLine ("\n");
			Console.WriteLine (array);
	}
   }
}

