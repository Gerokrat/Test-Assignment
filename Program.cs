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
            System.Threading.Thread.Sleep(5);
            var rnd = new System.Random();
            System.Threading.Thread.Sleep(10);
            RandomSide = rnd.Next(2, 20);
            return RandomSide;
        }

        public string ColorPick(string color)
        {
            System.Threading.Thread.Sleep(5);
            var rnd = new System.Random();
            System.Threading.Thread.Sleep(10);
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
