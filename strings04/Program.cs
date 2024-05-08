namespace strings04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //4.Del string 0000001234500000000 conseguir quedarse con
            //el string 12345 y mostrarlo por pantalla.



            //Console.WriteLine("Por favor ingrese el numero: ");
            //cadena = Console.ReadLine();


            string cadena = "0000001234500000000";

            int indiceInicio = cadena.IndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });

            if (indiceInicio != -1)
            {

                
                    int indiceFin = cadena.LastIndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });

                    int longitud = indiceFin - indiceInicio + 1;

                    string resultado = cadena.Substring(indiceInicio, longitud);

                Console.WriteLine("El numero es: " + cadena);

                Console.WriteLine("El numero deseado es: " + resultado);


            }
            else
            {
                    Console.WriteLine("Su cadena no contiene ceros iniciales ni finales.");
            }


        }





        
    }
}
