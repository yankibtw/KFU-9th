using System;
using System.Drawing;

namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1
            Console.WriteLine("Задание 1");
            ACipher value = new ACipher();
            string result = value.encode("же");
            Console.WriteLine(result);
            result = value.decode(result);
            Console.WriteLine(result);

            BCipher secondvalue = new BCipher();
            result = secondvalue.encode("ABCD");
            Console.WriteLine(result);
            result = secondvalue.encode("абв");
            Console.WriteLine(result);
            result = secondvalue.decode(result);
            Console.WriteLine(result);

            ///Задание 2
            Console.WriteLine("\nЗадание 2:");
            Point point = new Point(Color.Red, true, 10, 20);
            point.Display();

            point.HorizontalMove(5);
            point.VerticalMove(5);
            point.Display();

            Console.WriteLine();
            Circle circle = new Circle(Color.AliceBlue, true, 0, 0, 8);
            circle.Display();
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

            Console.WriteLine();
            Rectangle rectangle = new Rectangle(Color.DarkBlue, true, 5, 11, 8, 10);
            rectangle.Display();
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
        }
    }
}
