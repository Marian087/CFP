using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Funciones02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //2.Crear una función que determine si el número recibido por parámetro es primo o no.



            int numeroIngresado;

            Console.WriteLine("Ingrese un nùmero: ");
            numeroIngresado= Convert.ToInt32(Console.ReadLine());


            bool esPrimo = EsPrimo(numeroIngresado);

            if (esPrimo) 
            {
                Console.WriteLine(numeroIngresado + " es un número primo.");

            }
            else 
            {
                Console.WriteLine(numeroIngresado + " no es un número primo.");

            }

            static bool EsPrimo ( int numeroIngresado)
            {
                if (numeroIngresado <= 1)
                {
                    return false;
                }


                if (numeroIngresado <= 3)
                {
                    return true;
                }

                if (numeroIngresado % 2 == 0 || numeroIngresado % 3 == 0)
                {
                    return false;
                }


               

                return true;

            }
        }
    }
}
