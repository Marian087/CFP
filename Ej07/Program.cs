using System.Runtime.ConstrainedExecution;

namespace Ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(REPETITIVAS)
            //  Ingresar 15 números y determinar:
            //  Suma de los negativos.
            //Suma de los positivos.
            //Cantidad de positivos.
            //Cantidad de negativos.
            //Cantidad de ceros.
            //Cantidad de números pares.
            //Promedio de positivos.
            //Promedio de negativos.
            //Diferencia entre positivos y negativos, (positivos - negativos).
            //El número máximo
            //De los negativos el mínimo

            int[] numeros = new int[3];

            int sumaNegativos = 0;
            int sumaPositivos = 0;
            int cantPositivos = 0;
            int cantNegativos = 0;
            int cantCeros = 0;
            int cantPares = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int diferenciaPosNeg = 0;
            int numeroMaximo = 0;
            int numeroNegMinimo = 0;

            
            
            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine("Por favor ingrese el numero {0}", i + 1);
                Console.WriteLine(numeros[i]);

            }

            



            Console.WriteLine($"La suma de todos los nùmeros negativos es: {sumaNegativos}");
            Console.WriteLine($"La suma de todos los nùmeros positivos es: {sumaPositivos}");

        }
    }
}
