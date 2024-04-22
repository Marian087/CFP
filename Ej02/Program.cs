namespace Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2. Ingresar el nombre, apellido y edad por consola.

            string nombre;
            string apellido;
            string edad;
            int edadNumerica;

            Console.WriteLine("Por favor ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su edad: ");
            edad = Console.ReadLine();

            edadNumerica = int.Parse(edad);

            Console.WriteLine($"Muchas gracias {nombre} {apellido}, su edad es {edadNumerica}");
        }
    }
}
