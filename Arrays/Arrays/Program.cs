using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Company table with income, outcome and profit

            Console.WriteLine("Finance promo for using arrays");
            Console.WriteLine();
            Random randomize = new Random();
            int[] income = new int[12];
            int[] outcome = new int[12];
            int[] profit = new int[12];
            string[] header = new string[] { "Month", "Income, $", "Outcome, $", "Profit, $" };
            foreach (var item in header)
            {
                Console.Write(item.PadLeft(20));
            }
            Console.WriteLine();
            int positiveNumber = 0;
            for (int i = 0; i < 12; i++)
            {
                income[i] = randomize.Next(1, 100);
                outcome[i] = randomize.Next(1, 100);
                profit[i] = income[i] - outcome[i];
                if (profit[i] > 0)
                {
                    positiveNumber++;
                }
                string currentIncome = $"{income[i]} 000".PadLeft(20);
                string currentOutcome = $"{outcome[i]} 000".PadLeft(20);
                string currentProfit = $"{profit[i]} 000".PadLeft(20);
                Console.WriteLine($"{(i + 1).ToString().PadLeft(20)}{currentIncome}{currentOutcome}{currentProfit}");
            }
            HashSet<int> profitUnique = new HashSet<int>(profit);
            int[] sortedProfit = profitUnique.ToArray();
            Array.Sort(sortedProfit);
            Console.Write("Worst profit in months: ");
            for (int i = 0; i<profit.Length; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    if (profit[i] == sortedProfit[j])
                    {      
                        Console.Write($"{i+1} "); 
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Months with positive profit: {positiveNumber}");
            Console.ReadKey();
            Console.WriteLine();

            //Pascal's triangle
            Console.WriteLine("Pascal's triangle");
            Console.WriteLine();
            Console.WriteLine("Enter number of rows for Pascal`s triangle: ");
            int number = int.Parse(Console.ReadLine());

            int[][] triangle = new int[number][];
            int element = 1;

            int windowWidth = Console.WindowWidth;
            for (int i = 0; i < number; i++)
            {
                triangle[i] = new int[element];
                triangle[i][0] = 1;
                triangle[i][element - 1] = 1;

                string line = triangle[i][0].ToString();
                for (int j = 1; j < element-1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                    line += triangle[i][j].ToString().PadLeft(5);
                }

                if (i > 0) line += triangle[i][element - 1].ToString().PadLeft(5);
                if (line.Length < windowWidth) line = line.PadLeft((windowWidth - line.Length) / 2 + line.Length, ' ');
                Console.WriteLine(line);
                element++;
            }
            Console.ReadKey();   
        }
    }
}
