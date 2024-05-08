namespace strings05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Pedir el ingreso de nombre y apellido separado por un espacio, 
            //guardar cada dato en una variable diferente y asegurarse de que respete el formato de
            //la primera letra en mayúscula y el resto en minúsculas, mostrar el apellido y el nombre por separado.
            //ej: juAN ROBles(primero nombre luego apelido)
            //imprimir:
            //Apellido: Robles.
            //Nombre: Juan.


            string palabraIngresada;
            


            Console.WriteLine("Ingrese su nombre y apellido , separados por un espacio. ");
            palabraIngresada = Console.ReadLine();

            string[] partes = palabraIngresada.Split(' ');

            string nombre = partes[0].Substring(0, 1).ToUpper() + partes[0].Substring(1).ToLower();
            string apellido = partes[1].Substring(0, 1).ToUpper() + partes[1].Substring(1).ToLower();

            Console.WriteLine("Apellido: " + apellido + ".");
            Console.WriteLine("Nombre: " + nombre + ".");




        }
    }
}
