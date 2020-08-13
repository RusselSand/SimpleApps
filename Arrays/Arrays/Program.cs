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
            Console.WriteLine();

            //Matrix/number multiplication
            Console.WriteLine("Enter number of rows: ");
            int rowsMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            int columnsMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number for multiplication: ");
            int numberMatrix = int.Parse(Console.ReadLine());

            if((rowsMatrix == 0) || (columnsMatrix == 0)) Console.WriteLine("We cant create this matrix, sorry :(");

            else
            {
                int[,] matrix = new int[rowsMatrix, columnsMatrix];
                int[,] resultMatrix = new int[rowsMatrix, columnsMatrix];

                for (int i = 0; i < rowsMatrix;i++)
                {
                    string lineMatrix = "";
                    string lineResult = "";
                    for (int j = 0; j < columnsMatrix; j++)
                    {
                        matrix[i, j] = randomize.Next(1, 100);
                        resultMatrix[i, j] = matrix[i, j] * 5;
                        lineMatrix += matrix[i, j].ToString().PadLeft(4);
                        lineResult += resultMatrix[i, j].ToString().PadLeft(4);
                    }
                    Console.WriteLine($"| {lineMatrix} | {lineResult} |");
                }
            }

            Console.ReadKey();
            Console.WriteLine();

            //Matrix sum and difference
            Console.WriteLine("Enter number of rows: ");
            int rowsMatrix1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            int columnsMatrix1 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rowsMatrix, columnsMatrix];
            int[,] matrix2 = new int[rowsMatrix, columnsMatrix];
            int[,] result1 = new int[rowsMatrix, columnsMatrix];
            int[,] result2 = new int[rowsMatrix, columnsMatrix];

            string[] print1 = new string[rowsMatrix];
            string[] print2 = new string[rowsMatrix];

            for (int i = 0; i < rowsMatrix; i++)
            {
                string lineMatrix1 = "";
                string lineMatrix2 = "";
                string lineResult1 = "";
                string lineResult2 = "";

                for (int j = 0; j < columnsMatrix; j++)
                {
                    matrix1[i, j] = randomize.Next(1, 100);
                    matrix2[i, j] = randomize.Next(1, 100);
                    result1[i, j] = matrix1[i, j] + matrix2[i, j];
                    result2[i, j] = matrix1[i, j] - matrix2[i, j];

                    lineMatrix1 += matrix1[i, j].ToString().PadLeft(4);
                    lineMatrix2 += matrix2[i, j].ToString().PadLeft(4);
                    lineResult1 += result1[i, j].ToString().PadLeft(4);
                    lineResult2 += result2[i, j].ToString().PadLeft(4);
                }
                print1[i] = $"| {lineMatrix1} | {lineMatrix2} | {lineResult1} |";
                print2[i] = $"| {lineMatrix1} | {lineMatrix2} | {lineResult2} |";
            }

            Console.WriteLine("Sum: ");
            foreach (var item in print1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Difference: ");
            foreach (var item in print2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            //Matrix multiplication

            Console.WriteLine("Enter number of rows for 1 matrix: ");
            int rowsFirstMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns for 1 matrix: ");
            int columnsFirstMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of rows for 2 matrix: ");
            int rowsSecondMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns for 2 matrix: ");
            int columnsSecondMatrix = int.Parse(Console.ReadLine());

            if (columnsFirstMatrix != rowsSecondMatrix)
            {
                Console.WriteLine("We can`t multiply those matrix");
            }
            else
            {
                int[,] multiplyResult = new int[rowsFirstMatrix, columnsSecondMatrix];
                int[,] matrixFirst = new int[rowsFirstMatrix, columnsFirstMatrix];
                int[,] matrixSecond = new int[rowsSecondMatrix, columnsSecondMatrix];

                for (int i = 0; i < rowsFirstMatrix; i++)
                {
                    string LineResult = ""; 
                    for(int j = 0; j < columnsSecondMatrix; j++)
                    {
                        multiplyResult[i, j] = 0;

                        for (int k = 0; k < columnsFirstMatrix; k++)
                        {
                            matrixFirst[i, k] = randomize.Next(1, 10);
                            matrixSecond[k, j] = randomize.Next(1, 10);
                            multiplyResult[i, j] += matrixFirst[i, k] * matrixSecond[k, j];

                        }
                        LineResult += multiplyResult[i, j].ToString().PadLeft(4);
                    }
                    Console.WriteLine($"| {LineResult} |");
                }
                Console.WriteLine();
                Console.WriteLine("First matrix: ");
                for (int i = 0; i < rowsFirstMatrix; i++)
                {
                    string lineMatrixFirst = "";
                    for (int j = 0; j < columnsFirstMatrix; j++)
                    {
                        lineMatrixFirst += matrixFirst[i, j].ToString().PadLeft(4);
                    }
                    Console.WriteLine($"| {lineMatrixFirst} |");
                }
                Console.WriteLine();
                Console.WriteLine("Second matrix: ");
                for (int i = 0; i < rowsSecondMatrix; i++)
                {
                    string lineMatrixSecond = "";
                    for (int j = 0; j < columnsSecondMatrix; j++)
                    {
                        lineMatrixSecond += matrixSecond[i, j].ToString().PadLeft(4);
                    }
                    Console.WriteLine($"| {lineMatrixSecond} |");
                }
            }
            Console.ReadLine();    
        }
    }
}
