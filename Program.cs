using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotka
{
    public class Figure
    {
        static public int side { get; set; }
        public string color { get; set; }

        public int rnd(int RandomSide)
        {
            System.Threading.Thread.Sleep(1);
            var rnd = new System.Random();
            RandomSide = rnd.Next(2, 20);
            return RandomSide;
        }

        public string ColorPick(string color)
        {
            System.Threading.Thread.Sleep(1);
            var rnd = new System.Random();
            string[] colors = new string[] {"красный","оранжевый","желтый","зеленый","голубой","синий","фиолетовый" };
            color = colors[rnd.Next(0, 6)];
            return color;
        }

        public virtual void Draw()
        {
            Console.Write("Фигура: ");
        }
        public virtual void Square()
        {
            Console.Write(", площадь: ");
        }
        public virtual void Color()
        {
            Console.Write(", цвет: ");
            Console.Write(ColorPick(color));
            Console.WriteLine();
        }
        public virtual void Special()
        {

        }
    }

    public class FourSquare : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("квадрат");
        }
        public override void Square()
        {
            side=rnd(side);
            base.Square();
            Console.Write(side*side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" сторона: ");
            Console.Write(side);
        }
    }

    public class Triangle : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("триугольник");
        }
        public override void Square()
        {
            side = rnd(side);
            base.Square();
            Console.Write(side*0.5*side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" гипотенуза: ");
            Console.Write(Math.Sqrt(side*side));
        }
    }

    public class Circle : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("круг");
        }
        public override void Square()
        {
            side = rnd(side);
            base.Square();
            Console.Write(side*side*3.14);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" радиус: ");
            Console.Write(side);
        }
    }

    public class Trapeze : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("трапеция");
        }
        public override void Square()
        {
            int a = rnd(side);
            System.Threading.Thread.Sleep(1);
            int b = rnd(side);
            side = rnd(side);
            base.Square();
            Console.Write((a+b/2)*side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" висота: ");
            Console.Write(side);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure> { };
            var rnd = new Random();

            for(int i=0;i<rnd.Next(5,10);i++)
            {
                figures.Add(new Circle());
                figures.Add(new Triangle());
                System.Threading.Thread.Sleep(1);
                figures.Add(new FourSquare());
                figures.Add(new Trapeze());
            }

            var shuffle = figures.OrderBy(item => rnd.Next());

            foreach (var figure in shuffle)
            {
                figure.Draw();
                figure.Square();
                figure.Special();
                figure.Color();
            }
            Console.ReadKey();
        }
    }
}
