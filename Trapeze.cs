using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotka
{
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
            Console.Write((a + b / 2) * side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            Console.Write(" висота: ");
            Console.Write(side);
        }
    }
}
