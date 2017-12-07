using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotka
{
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
            Console.Write(side * 0.5 * side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" гипотенуза: ");
            Console.Write(Math.Sqrt(side * side));
        }
    }
}
