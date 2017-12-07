using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Robotka
{
    public class FourSquare : Figure
    {
        public override void Draw()
        {
            base.Draw();
            Console.Write("квадрат");
        }
        public override void Square()
        {
            side = rnd(side);
            base.Square();
            Console.Write(side * side);
            Console.Write(" кв. ед.");
        }
        public override void Special()
        {
            base.Special();
            Console.Write(" сторона: ");
            Console.Write(side);
        }
    }
}
