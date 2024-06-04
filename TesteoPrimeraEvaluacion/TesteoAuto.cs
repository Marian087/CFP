using LibreriaAuto;
using System.Drawing;
using System.Timers;

namespace TesteoPrimeraEvaluacion
{
    internal class TesteoAuto
    {
        

        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Toyota", 65, Color.Black);
            int repeticiones = 0;

            Console.WriteLine(miAuto.AutoToString());

            while (miAuto.Avanzar(8)) // aca verifico si mi auto recorrio 8 km
            {

                repeticiones ++;
                          
            
            }
            Console.WriteLine($"El auto se quedo sin combustible y logro realizar {repeticiones} repeticones");
            
            
            
        }
    }
}
