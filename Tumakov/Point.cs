using System;
using System.Drawing;

namespace Tumakov
{
    class Point : Figure
    {
        protected int x, y;

        public Point(Color color, bool isVisible, int x, int y) : base(color, isVisible)
        {
            this.x = x;
            this.y = y;
        }
        public override void HorizontalMove(int distance){
            x += distance;
        }
        public override void VerticalMove(int distance) {  
            y += distance; 
        }
        public override void Display()
        {
            Console.WriteLine($"Точка с координатами: {x}, {y}\nЦвет: {color}\nСостояние: {isVisible}");
        }

    }
}
