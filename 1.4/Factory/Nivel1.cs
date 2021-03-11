using _1._4.Lupte;
using System;
using System.Collections.Generic;
using System.Text;


namespace _1._4.Factory
{
    class Nivel1 : INivelFactor
    {
        public Luptatori CreateLuptatori()
        {
            return new   LuptatoriTurci ();
        }

        public Teritoriu CreateTeritoriu()
        {
           return new TeritoriulCetatilor() ;
        }

       
    }
}
