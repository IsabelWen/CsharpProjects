using System;

class Eurojackpot
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jackpot Numbers");
        Console.WriteLine("---------------");

        Random num = new Random();
        int[] numbers = new int[4];
        int[] euronumbers = new int[2];
        
        // Choose a special number
        int[] specialNumbers = { 1, 8, 11, 13 };
        int special = specialNumbers[num.Next(specialNumbers.Length)];

        Console.WriteLine($"Special number: {special}");

        Console.WriteLine("Numbers:");

        // Normal numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            int nextNum = 0;
            do
            {
                nextNum = num.Next(1, 51);
            } while (nextNum == 19 || nextNum == 49 || Array.IndexOf(numbers, nextNum) != -1);
            numbers[i] = nextNum;
            Console.Write($"{numbers[i]}, ");
        }

        Console.WriteLine("\nEuronumbers:");

        // Euronumbers
        for (int i = 0; i < euronumbers.Length; i++)
        {
            int nextEuronum = 0;
            do
            {
                nextEuronum = num.Next(1, 13);
            } while (nextEuronum == 5 || Array.IndexOf(euronumbers, nextEuronum) != -1);
            euronumbers[i] = nextEuronum;
            Console.Write($"{euronumbers[i]}, ");
            }
    }
}

