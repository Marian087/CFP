namespace Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //3. Ingresar 2 números y mostrar la suma de los mismos.



            string numeroTextoUno;
            string numeroTextoDos;
            int numeroUno;
            int numeroDos;


            int suma;

            Console.WriteLine("Ingrese el primer nùmero: ");
            numeroTextoUno = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo nùmero: ");
            numeroTextoDos = Console.ReadLine();

            numeroUno = int.Parse(numeroTextoUno);
            numeroDos = int.Parse(numeroTextoDos);



            Console.WriteLine($"La suma de sus dos números es : {numeroUno + numeroDos} ");

        }
    }
}
