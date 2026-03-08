

		Console.Write("Ingrese el tamaño del rombo: ");
		int n = int.Parse(Console.ReadLine()!);

		int half = n / 2;

		// Top
		for (int i = 0; i <= half; i++)
		{
			for (int j = 0; j < half - i; j++)
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

		// Bottom
		for (int i = half - 1; i >= 0; i--)
		{
			for (int j = 0; j < half - i; j++)
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

	
