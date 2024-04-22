namespace Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Ingresar el nombre y apellido por consola.
            string nombre;
            string apellido;


            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();


            Console.WriteLine($"Muchas gracias {nombre} {apellido}!");

        }
    }
}
