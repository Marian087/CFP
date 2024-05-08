namespace strings03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3.Pedir el ingreso de una palabra y reemplazar todas las letras A por un
            //carácter especial(* , & , etc).
            //ej: Manzana->M * nz * n *.

            string palabra;
            string palabraReemplazada;


            Console.WriteLine("Por favor ingrese una palabra: ");
            palabra = Console.ReadLine();

            palabraReemplazada = palabra.Replace('A', '*');

            Console.WriteLine("Su palabra es :" + palabraReemplazada);


        }
    }
}
