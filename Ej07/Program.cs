using System.Runtime.ConstrainedExecution;

namespace Ej07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(REPETITIVAS)
            //  Ingresar 15 números y determinar:
            //  Suma de los negativos.
            //Suma de los positivos.//
            //Cantidad de positivos.//
            //Cantidad de negativos.//
            //Cantidad de ceros.//
            //Cantidad de números pares.
            //Promedio de positivos.
            //Promedio de negativos.
            //Diferencia entre positivos y negativos, (positivos - negativos).
            //El número máximo
            //De los negativos el mínimo

            int[] numeros = new int[5];

            int sumaNegativos = 0;
            int sumaPositivos = 0;
            int cantPositivos = 0;
            int cantNegativos = 0;
            int cantCeros = 0;
            int cantPares = 0;
            int sumaPares = 0;
            double promedioPositivos = 0;
            double promedioNegativos = 0;
            int diferenciaPosNeg = 0;
            int numeroMaximo = 0;
            int numeroNegMinimo = 0;



            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Por favor ingrese el numero {i+1} de 15: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());  
                
                if (numeros[i] > 0)
                {
                    sumaPositivos+= numeros[i];
                    cantPositivos++;


                }
                else 
                {
                    if (numeros[i] == 0)
                    {
                        cantCeros++;
                    
                    }
                    else 
                    {
                        sumaNegativos += numeros[i];
                       

                        if (numeros[i] < numeroNegMinimo)
                        {
                            numeroNegMinimo = numeros[i];
                                                
                        }

                        cantNegativos++;

                    }


                }

                if (numeros[i] % 2 == 0)
                {
                    sumaPares += numeros[i];
                    cantPares++;

                }
                if (numeros[i] > numeroMaximo)
                {
                    numeroMaximo = numeros[i];
                }

                if (cantNegativos > 0)
                {
                    promedioNegativos = (double)sumaNegativos / cantNegativos;

                }
                    
               if (cantPositivos > 0)
               {
                    promedioPositivos = (double)sumaPositivos / cantPositivos; 
                
               }

               diferenciaPosNeg = sumaPositivos - sumaNegativos;




            }


            Console.WriteLine($"La suma de todos los nùmeros positivos es: {sumaPositivos}");
            Console.WriteLine($"La cantidad de los nùmeros positivos es: {cantPositivos}");
            Console.WriteLine($"La cantidad de los nùmeros negativos es: {cantNegativos}");

            Console.WriteLine($"La cantidad de numeros ceros es de: {cantCeros}");
            Console.WriteLine($"La cantidad de nùmeros pares es: {cantPares}");
            Console.WriteLine($"El promedio de nùmeros positivos es de: {promedioPositivos}");

            Console.WriteLine($"El promedio de nùmeros negativos es de: {promedioNegativos}");

            Console.WriteLine($"La diferencia entre los numeros positivos y negativos es de: {diferenciaPosNeg}");

            Console.WriteLine($"El nùmero màximo es: {numeroMaximo}");

            Console.WriteLine($"El nùmero negativo minimo es: {numeroNegMinimo}");
        }
    }
}
