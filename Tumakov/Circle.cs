using System;
using System.Drawing;


namespace Tumakov
{
    class Circle : Point
    {
        private double radius;
        public Circle(Color color, bool isVisible, int x, int y, double radius) : base (color, isVisible, x, y)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Display()
        {
            Console.WriteLine($"Круг с центром в: X = {x}, Y = {y}\nЦвет: {color}\nСостояние: {isVisible}\nРадиус: {radius}");
        }
    }
}
