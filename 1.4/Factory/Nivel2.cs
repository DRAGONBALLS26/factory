using _1._4.Lupte;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1._4.Factory
{
    class Nivel2 : INivelFactor
    {
        public Luptatori CreateLuptatori()
        {
            return new LuptatoriMoldoveni();
        }

        public Teritoriu CreateTeritoriu()
        {
            return new TeritoriulPadurilor();

        }
    }
}
