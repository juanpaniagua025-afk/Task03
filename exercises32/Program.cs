using System;

class Program
{
	static void Main()
	{
		Console.Write("Ingrese el tamaño del rombo: ");
		int n = int.Parse(Console.ReadLine()!);

		int mitad = n / 2;

		// Parte superior
		for (int i = 0; i <= mitad; i++)
		{
			for (int j = 0; j < mitad - i; j++)
				Console.Write(" ");

			Console.Write("#");

			if (i > 0)
			{
				for (int j = 0; j < 2 * i - 1; j++)
					Console.Write(" ");

				Console.Write("#");
			}

			Console.WriteLine();
		}

		// Parte inferior
		for (int i = mitad - 1; i >= 0; i--)
		{
			for (int j = 0; j < mitad - i; j++)
				Console.Write(" ");

			Console.Write("#");

			if (i > 0)
			{
				for (int j = 0; j < 2 * i - 1; j++)
					Console.Write(" ");

				Console.Write("#");
			}

			Console.WriteLine();
		}

		Console.ReadKey();
	}
}