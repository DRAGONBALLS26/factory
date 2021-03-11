using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.Lupte
{
    class TeritoriulCetatilor:Teritoriu
    {
        public TeritoriulCetatilor() {
            Name = "Cetate";
        }

        public override void Draw() {
            Console.WriteLine("Se implimenteaza Draw la TeritoriulCetatilor...");
        }
    }
}
