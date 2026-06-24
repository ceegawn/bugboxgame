using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("BugBox CI Game Starting...");

        int score = 0;

        for (int tick = 0; tick < 5; tick++)
        {
            Console.WriteLine($"Tick {tick} - Player moves - Score: {score}");
            score += 10;
            System.Threading.Thread.Sleep(300);
        }

        Console.WriteLine($"Game Over! Final Score: {score}");
    }
}