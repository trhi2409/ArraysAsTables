using System;

namespace ArraysAsTables
{
    public static class AAT
    {
        static void Main(string[] args)
        {
            
        }

		//תומך במספרים עד 100,000 (אפשר לשנות את הפדינג והחישובים פה של הסטרינגים בשביל שיתמוך במספרים גדולים יותר ושיהיה עוד מקום בכל איבר)
		public static void PrintArray(int[] arr)
		{
			int fixedLength = arr.Length > 25 ? 25 : arr.Length;
			Console.WriteLine("┌" + new string('─', fixedLength * 8 - 1) + "┐");
			for (int i = 0; i < arr.Length; i++)
			{
				string Value = arr[i].ToString();
				int padding = 5 - Value.Length, left = padding / 2, right = padding - left > 0 ? padding - left : 0;
				Console.Write("│ {0}{1}{2} ", new string(' ', left), Value, new string(' ', right));
				if ((i + 1) % 25 == 0 || i == arr.Length - 1)
				{
					Console.Write("│");
					if (i < arr.Length - 1)
						Console.WriteLine("\n├" + new string('─', 199) + "┤");
					else if (arr.Length % 25 != 0)
						Console.WriteLine("\n└" + new string('─', arr.Length % 25 * 8 - 1) + "┘");
				}
			}
			if (arr.Length % 25 == 0)
				Console.WriteLine("\n└" + new string('─', 199) + "┘");
		}

		//תומך במספרים עד 100,000 (אפשר לשנות את הפדינג והחישובים פה של הסטרינגים בשביל שיתמוך במספרים גדולים יותר ושיהיה עוד מקום בכל איבר)
		public static void Print2dArray(int[,] arr)
		{

			int rows = arr.GetLength(0);
			int cols = arr.GetLength(1);

			Console.WriteLine($"┌{new string('─', cols * 6 - 1)}┐");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("│");

				for (int j = 0; j < cols; j++)
				{
					string Value = arr[i, j].ToString();
					int padding = 5 - Value.Length, left = padding / 2, right = padding - left;
					Console.Write("{0}{1}{2}│", new string(' ', left), Value, new string(' ', right));
				}

				Console.WriteLine();
				if (i < rows - 1)
					Console.WriteLine($"├{new string('─', cols * 6 - 1)}┤");
			}

			Console.WriteLine($"└{new string('─', cols * 6 - 1)}┘");
		}

		//ממלא מספרים עד 100,000 במערך דו מימדי
		public static void Fill2dArray(int[,] arr)
		{
			Random rnd = new Random();
			for (int i = 0; i < arr.GetLength(0); i++)
				for (int j = 0; j < arr.GetLength(1); j++)
					arr[i, j] = rnd.Next(100000);
		}

		//ממלא מספרים עד 100,000 במערך רגיל
		public static void FillArray(int[] arr)
		{
			Random rnd = new Random();
			for (int i = 0; i < arr.Length; i++)
				arr[i] = rnd.Next(100000);
		}
	}
}
