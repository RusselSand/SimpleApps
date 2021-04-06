using System.Data;
using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        public static bool BracketCheck(string mathString)
        {
            DataTable dt = new DataTable();
            try
            {
                var result = dt.Compute(mathString, "");
                return true;
            }
            catch (SyntaxErrorException)
            {
                return false;
            } 
        }

        /// <summary>
        /// Method for multiplying matrix by number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="matrix"></param>
        /// <returns> new matrix</returns>
        public static int[,] MultiplyMatrixNumber(int number, int[,] matrix)
        {

            int lines = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] newMatrix = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * number;
                }
            }
            return newMatrix;
        }
        /// <summary>
        /// Method for catching sum of two matrix
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int[,] MatrixSum(int[,] matrix1, int[,] matrix2)
        {
            int lines = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] newMatrix = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;

        }
        /// <summary>
        /// Method for multiplying two matrix
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {

            int lines1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int lines2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);
            int[,] multiplyResult = new int[lines1, columns2];
            for (int i = 0; i < lines1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    multiplyResult[i, j] = 0;
                    for (int k = 0; k < columns1; k++)
                    {
                        multiplyResult[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return multiplyResult;
        }
        /// <summary>
        /// Method for creation of random matrix with given rows and columns
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        public static int[,] RandomMatrix(int rows, int columns)
        {
            Random randomize = new Random();

            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = randomize.Next(1, 100);
                }
            }
            return matrix;
        }
        public static string MaxLetters(string text)
        {
            string[] words = text.Split(' ');
            int maxLength = 0;
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (word.Length >= maxLength) maxLength = word.Length;
            }
            foreach(string word in words)
            {
                if (word.Length == maxLength) result.Add(word);
            }

            return String.Join(", ",result);
        }
        public static string MinLetters(string text)
        {
            string[] words = text.Split(' ');
            int minLength = 1;
            List<string> result = new List<string>();
            
            foreach (string word in words)
            {
                int x = word.Length;
                if (x <= minLength){
                    result.Add(word);
                    minLength = x;
                }
            }
            return String.Join(", ", result);
        }
        public static string DeleteDuplicates(string text)
        {
            string result = "";
            char checkletter = '\0';
            foreach (char letter in text)
            {
                if (checkletter != Char.ToLower(letter))
                {
                    result += letter;
                    checkletter = Char.ToLower(letter);
                }

            }
            return result;
        }
        public static string CheckProgression(int firstNumber, params int[] numbers)
        {
            string result = "";
            for (int i = 1; i <= numbers[0]; i++)
            {
                int startNumber = firstNumber;
                foreach(int number in numbers)
                {
                    if(startNumber * i == number)
                    {
                        result = "Геометрическая прогрессия.";
                    }
                    else
                    {
                        result = "Просто числа.";
                        break;
                    }
                }
                foreach (int number in numbers)
                {
                    if (startNumber + i == number)
                    {
                        result = "Арифметическая прогрессия.";
                    }
                    else
                    {
                        result = "Просто числа.";
                        break;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[,] matrix1 = RandomMatrix(2, 3);
            int [,] matrixResult = MultiplyMatrixNumber(2, matrix1);
            int[,] matrix2 = RandomMatrix(2, 3);
            int[,] matrixResult1 = MatrixSum(matrix1, matrix2);
            int[,] matrix3 = RandomMatrix(3, 2);
            int[,] matrixResult2 = MultiplyMatrix(matrix3, matrix2);

            Console.ReadKey();
            Console.WriteLine(MinLetters("A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"));
            Console.ReadKey();
            Console.WriteLine(MaxLetters("A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"));
            Console.ReadKey();
            Console.WriteLine(DeleteDuplicates("ПППОООГГГООООДДДААА"));
            Console.WriteLine(DeleteDuplicates("Ххххоооорррооошшшиий деееннннь"));
            Console.ReadKey();
            Console.WriteLine(CheckProgression(1,2,4,8,16));
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован
        }
    }
}
