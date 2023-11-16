using System;
using System.Drawing;

namespace Tumakov
{
    class Rectangle : Point
    {
        private double width, height;
        public Rectangle(Color color, bool isVisible, int x, int y, double width, double height) : base(color, isVisible, x, y)
        {
            this.width = width;
            this.height = height;
        }
        public double CalculateArea()
        {
            return width * height;
        }
        public override void Display()
        {
            Console.WriteLine($"Прямоугольник с координатами: X = {x}, Y = {y}\nЦвет: {color}\nСостояние: {isVisible}\nШиринa: {height}\nВысота: {height}");
        }
    }
}
