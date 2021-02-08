using System;

namespace Variables
{
    class Program
    {
        /// <summary>
        /// Row for fill data with upcoming message
        /// </summary>
        /// <returns>returns string result</returns>
        public static string ReceiveMessage(string message)
        {
            Console.WriteLine(message);
            var rawResult = Console.ReadLine();
            return rawResult;
        }
        /// <summary>
        /// Transform received data to byte format
        /// </summary>
        /// <returns>returns byte result or send message that number is too big</returns>
        public static byte ReceiveByteResult(string message)
        {
            var rawResult = ReceiveMessage(message);
            try
            {
                byte result = byte.Parse(rawResult);
                return result;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Number is too big!");
                return ReceiveByteResult(message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wrong type!");
                return ReceiveByteResult(message);
            }
        }
        /// <summary>
        /// Main app
        /// </summary>
        static void Main(string[] args)
        {
            //Student data
            string name = ReceiveMessage("Set student name: ");
            var age = ReceiveByteResult("Set student age: ");
            var height = ReceiveByteResult("Set student height: ");

            //Student test results
            
            byte history = ReceiveByteResult("Please fill history result: ");
            byte maths = ReceiveByteResult("Please fill maths result: ");
            byte language = ReceiveByteResult("Please fill language result: ");

            var meanresult = (history + maths + language) / 3;

            string pattern = "Name: {0}, Age: {1}, Height: {2}, Mean results: {3}";
            Console.WriteLine(pattern, name, age, height, meanresult);

            Console.ReadKey();
        }
    }
}
