namespace strings01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres
            //de no ser así informar, luego mostrar los primeros 3 caracteres.
            // ej: zapallo->zap

            String palabra;



            while (true)
            {
                Console.WriteLine("Por favor ingrese una palabra de 5 caracteres: ");
                palabra = Console.ReadLine();

                if (palabra.Length < 5)
                { 
                    Console.WriteLine("Por favor ingrese una palabra correcta");
               
                
                }
                else
                {
                   if (palabra.Length >= 5);
                    {
                        Console.WriteLine("Los primeros 3 caracteres de la palabra son: " + palabra.Substring(0, 3));

                      

                    }
                   


                    break;

                }


            }
            


        }
    }
}
