using System;
using System.Drawing;

namespace Tumakov
{
    abstract class Figure
    {
        protected Color color;
        protected bool isVisible;

        public Figure(Color color, bool isVisible = true) {
            this.color = color;
            this.isVisible = isVisible;
        }

        public abstract void HorizontalMove(int distance);
        public abstract void VerticalMove(int distance);

        public void ChangeColor(Color color)
        {
            this.color = color;
        }
        public bool IsVisibleFigure()
        {
            return isVisible;
        }

        public virtual void Display() {
            Console.WriteLine($"Цвет: {color}\nСостояние: {isVisible}");
        }
    }
}
