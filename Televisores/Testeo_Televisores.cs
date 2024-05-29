using Libreria_Televisor;

namespace Televisores
{
    internal class Testeo_Televisores
    {
        static void Main(string[] args)
        {
                 
            Console.WriteLine("Buenas tardes, elija su televisor:");

            Televisor televisor1 = new Televisor("TCL", 32, "T32X", "NEGRO");
            Televisor televisor2 = new Televisor("SONY", 24, "B24C", "PLATEADO");
            Televisor televisor3 = new Televisor("NOBLEX", 43, "F435", "ROJO");
            Televisor televisor4 = new Televisor("PHILIPS", 50, "PHG5", "NEGRO");
            Televisor televisor5 = new Televisor("SAMSUNG", 65, "S245", "BLANCO");

            List<Televisor> listaDeTelevisores = new List<Televisor>();

           

        }
    }
}
