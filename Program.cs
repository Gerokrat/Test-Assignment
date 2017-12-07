using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotka
{
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
