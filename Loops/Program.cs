using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple game for 2 players: program chose regular number between 12 and 120, users chose  1, 2, 3 or 4. 
            //This number substracts from gamenumber. User, who receive 0 — wins.

            Console.WriteLine("Chose number of players: 1 — with computer, 2 — fight between two players");

            int playersNumber = 0;
            do
            {
                bool playersInput = int.TryParse(Console.ReadLine(), out playersNumber);
                if (playersInput)
                {
                    if (playersNumber > 2) Console.WriteLine("You can`t chose so many players :(");
                }
                else
                {
                    Console.WriteLine("This is not number. Please, try again!");
                } 
            }
            while ((playersNumber != 1) && (playersNumber != 2));


            Console.WriteLine("Start");
            Console.ReadLine();

            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!


        }
    }
}
