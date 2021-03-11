using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.Lupte
{
    class LuptatoriTurci : Luptatori
    {

        public LuptatoriTurci() 
        {
            HP = 100;
        }
        public override void Spawn()
        {
            Console.WriteLine($"Facem spawn cu {HP} la luptatorii Turci");
        }
    }
}
