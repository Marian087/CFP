using Libreria_Funciones;

namespace Vectores01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  1.Cargar un vector de enteros de 5 elementos y mostrarlo.

            //int[] numeros = new int[5];   // declaracion e inicializaciòn de Un array de 5 elementos

            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(5);

            MisFunciones.ImprimirArray($"Los números ingresados son: ", misNumeros);



        }
    }
}
