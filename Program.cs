using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // число от 1 до 100
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("=== Guess The Number Game ===");
        Console.WriteLine("I have chosen a number between 1 and 100.");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
