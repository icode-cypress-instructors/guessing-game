using System;

namespace GuessingGame;

class Program
{
	static void Main()
	{
		Console.WriteLine("Welcome to the Guess the Number Game!");
		Console.WriteLine("Enter the range for the random number (or press Enter for the default values).");

		Console.Write("Minimum (1): ");
		int minimum = ReadInt(Console.ReadLine(), 1);

		Console.Write("Maximum (100): ");
		int maximum = ReadInt(Console.ReadLine(), 100);

		Console.WriteLine($"The computer has generated a random number between {minimum} and {maximum}.");
		Console.WriteLine("Try to guess the number in as few attempts as possible.");

		// Generate the random number
		Random random = new Random();
		int target = random.Next(minimum, maximum + 1);

		// Start the game loop
		int guess = 0;
		int attempts = 0;
		while (guess != target)
		{
			Console.Write("Enter your guess: ");
			guess = ReadInt(Console.ReadLine(), minimum, minimum, maximum);
			attempts++;

			if (guess < target)
			{
				Console.WriteLine("Too low! Try again.");
			}
			else if (guess > target)
			{
				Console.WriteLine("Too high! Try again.");
			}
		}

		// The player won!
		Console.WriteLine($"You won! The number was {target}.");
		Console.WriteLine($"It took you {attempts} attempts to guess the number.");
		// Wait for the user to press a key before exiting
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
	}

	static int ReadInt(string? input, int defaultValue, int minValue = int.MinValue, int maxValue = int.MaxValue)
	{
		if (string.IsNullOrWhiteSpace(input))
		{
			return defaultValue;
		}

		int value;
		while (!int.TryParse(input, out value) || value < minValue || value > maxValue)
		{
			Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
			input = Console.ReadLine()!;
		}

		return value;
	}
}