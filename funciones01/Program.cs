using System.Runtime.ConstrainedExecution;

namespace funciones01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Crear una función que evalúe si una palabra es corta o larga.
            //Se considera larga si tiene más de 8 caracteres.
            //La función debe recibir un parámetro de tipo cadena(string) y
            //su retorno debe ser booleano.



            string palabra;

            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();

            bool esLarga = EsLarga(palabra); //funciòn

            if (esLarga) 
            {
                Console.WriteLine("La palabra es larga.");
            
            }
            else 
            {
                Console.WriteLine("La palabra es corta.");

            }

            static bool EsLarga ( string palabra) 
            {
                return palabra.Length > 8;
            
            }




        }
    }
}
