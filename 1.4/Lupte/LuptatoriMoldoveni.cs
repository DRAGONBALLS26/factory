using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.Lupte
{
    class LuptatoriMoldoveni : Luptatori
    {
        public LuptatoriMoldoveni() {
            HP = 75;
        }
        
        public override void Spawn()
        {
            Console.WriteLine($"Facem spawn cu {HP} la luptatorii Moldoveni");
        }
    }
}
