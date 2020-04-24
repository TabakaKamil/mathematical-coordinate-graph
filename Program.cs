using System;

namespace MathHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sprawdzenie, w której ćwiartce znajduje się punkt (x,y) - użyta funkcja CheckSquare() & CheckIfCorrect();
            Console.WriteLine("Sprawdź, na której ćwiartce znajduje się punkt. Współrzędne 'x' oraz 'y' muszą być > 0 || < 0");
            CheckSquare(GetIntFromConsole("Podaj x: "), GetIntFromConsole("Podaj y: "));

            Console.ReadKey();
        }
        static void CheckSquare(int x, int y)
        {

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Punkt ({0},{1}) znajduje się w ćwiartce 2 - górna, lewa.", x, y);
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Punkt ({0},{1}) znajduje się w ćwiartce 1 - górna, prawa.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Punkt ({0},{1}) znajduje się w ćwiartce 3 - dolna, lewa.", x, y);
            }
            else
            {
                Console.WriteLine("Punkt ({0},{1}) znajduje się w ćwiartce 4 - dolna, prawa.", x, y);
            }
        }
        static int GetIntFromConsole(string message)
        {
            bool isCorrect = false;
            int result = 0;
            while (!isCorrect)
            {
                try
                {
                    Console.WriteLine(message);
                    result = int.Parse(Console.ReadLine());
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podaj poprawny format - liczbę.");
                }
            }
            return result;
        }
    }
}
