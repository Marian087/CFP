namespace Ej04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////4. Ingresar 5 números enteros, calcular y mostrar el promedio.




            int[] misNumeros = new int[5];
            int suma = 0;
            double resultado;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1} de 5 : ");
                misNumeros[i] = int.Parse(Console.ReadLine());


                suma += misNumeros[i];

            }
            resultado = (double)suma / misNumeros.Length;


            Console.WriteLine($"La suma de sus números es:  {suma}");
            Console.WriteLine($"El promedio de sus números es:  {resultado}");

        }
    }
}
