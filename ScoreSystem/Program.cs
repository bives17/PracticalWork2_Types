
using System;

namespace ScoreSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SCORE CALCULATION SYSTEM");
            Console.WriteLine("Enter points for three game levels:");

            int[] scores = new int[3];
            int totalScore = 0;

            for (int i = 0; i < 3; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    try
                    {
                        Console.Write("Level " + (i + 1) + " points: ");
                        string input = Console.ReadLine();
                        scores[i] = Convert.ToInt32(input);
                        totalScore += scores[i];
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Please enter a valid integer!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error: Number is too large or too small!");
                    }
                }
            }

            double averageScore = (double)totalScore / 3;

            object boxedTotalScore = totalScore;
            Console.WriteLine("Boxed total: " + boxedTotalScore + " (Type: " + boxedTotalScore.GetType() + ")");

            int unboxedTotalScore = (int)boxedTotalScore;
            Console.WriteLine("Unboxed total: " + unboxedTotalScore + " (Type: " + unboxedTotalScore.GetType() + ")");

            Console.WriteLine("Total score: " + unboxedTotalScore);
            Console.WriteLine("Average score: " + averageScore.ToString("F2"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
