using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotka
{
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
            Console.Write(side * side * 3.14);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            Console.Write(" радиус: ");
            Console.Write(side);
        }
    }
}
