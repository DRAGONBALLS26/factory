using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.Lupte
{
    class TeritoriulPadurilor : Teritoriu
    {

        public TeritoriulPadurilor() {
            Name = "Padure";
        }

        public override void Draw()
        {
            Console.WriteLine("Se implimenteaza Draw la TeritoriulPadurilor...");
        }
    }
}
