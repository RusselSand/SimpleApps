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
        /// <summary>
        /// Method to get word with max quantity of letters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method to get word with min quantity of letters
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method to delete dublicate chars from text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Method to check if array is geometric or arithmetic progression
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string CheckProgression(int firstNumber, params int[] numbers)
        {
            string result = "";
            int checkArifm = 0;
            int checkGeom = 0;
            for (int i = 1; i <= numbers[0]; i++)
            {
                int startNumber = firstNumber;
                checkArifm = 0;
                checkGeom = 0;
                foreach(int number in numbers)
                {
                    if(startNumber * i != number)
                    {
                        checkGeom++;
                    }
                    if(startNumber + i != number)
                    {
                        checkArifm++;
                    }
                    startNumber = number;
                }
                if (checkArifm == 0 || checkGeom == 0){
                    break;
                }
            }
            if (checkArifm == 0){ result = "This is arithmetic progression."; }
            else if(checkGeom == 0) { result = "This is geometric progression."; }
            else { result = "Just numbers."; }
            return result;
        }
        public static int Akkerman(int n, int m)
        {
            if(n == 0)
            {
                return m + 1;
            }
            else if (n != 0 && m == 0)
            {
                return Akkerman(n - 1, 1);
            }
            else
            {
                return Akkerman(n - 1, Akkerman(n, m - 1));
            }
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
            Console.ReadKey();
            Console.WriteLine(Akkerman(1, 2));
            Console.WriteLine(Akkerman(2, 3));
            Console.WriteLine(Akkerman(3, 4));
            Console.ReadKey();

        }
    }
}
