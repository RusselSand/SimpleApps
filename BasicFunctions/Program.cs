using System;

namespace BasicFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //User basic info
            string name = "James";
            int age = 18;

            //Exam scores
            int history = 98;
            int maths = 80;
            int english = 75;

            int mean_score = (history + maths + english) / 3;

            //Interpolation
            string line = $"Mean exam score for {name}, age {age}: {mean_score}";

            //Print in the center of the console: 

            //1. Detect window width.
            int windowWidth = Console.WindowWidth;

            //2. Check, if line length is less then window width, use PadLeft
            if (line.Length < windowWidth) line = line.PadLeft((windowWidth - line.Length) / 2 + line.Length, ' ');
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
