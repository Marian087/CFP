namespace strings02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Pedir el ingreso de una palabra y mostrarla con todos sus caracteres
            //separados por un guión.
            // ej: Montaña->M - o - n - t - a - ñ - a.

            string palabra;

            Console.WriteLine("Por favor ingrese una palabra: ");
            palabra= Console.ReadLine();

             foreach (char caracter in palabra)
            {
                if (caracter != palabra[palabra.Length - 1])
                {
                    Console.Write(caracter + " - ");
                }
                else
                {
                    Console.Write(caracter);
                }

                                  
            }
    
        }

    }   
}
