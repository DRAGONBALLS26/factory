using _1._4.Factory;
using _1._4.Lupte;
using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            INivelFactor factory = new Nivel2 ();
            
            Luptatori luptatori  = factory.CreateLuptatori ();
            Teritoriu teritoriu = factory.CreateTeritoriu();

            teritoriu.Draw();
            luptatori.Spawn();

        }
    }
}
