using System.Security.Cryptography.X509Certificates;

namespace Libreria_Televisor
{
    public class Estudiante
    {
        // Tendrá un constructor estático que inicializará el atributo estático random.
        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido
        //y legajo.
        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo
        //notaPrimerParcial.
        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo
        //notaSegundoParcial.
        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        //El método CalcularNotaFinal deberá retornar la nota del final con un número
        //aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo
        //parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor - 1.
        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos
        //los datos de los alumnos:


        // Tendrá un constructor estático que inicializará el atributo estático random.
        private static Random random;

        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido
        //y legajo.
        private string nombre;
        private string apellido;
        private int legajo;
        
        private int notaPrimerParcial;
        private int notaSeguntoParcial;
        


        // constructor de instancia inicializar los atributos
        public Estudiante(string apellido, string nombre, int legajo) 
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
           
                                   
        }

        
        static Estudiante() //random
        {
            random = new Random();
        
        }

        public string GetNombre() 
        {
            return this.nombre;
        
        }

        public string GetApellido()
        {
            return this.apellido;

        }
        public int GeTLegajo() 
        {
            return this.legajo;
                
        }


        //metodos set para cambiar el valor del atributo
        public void SetNotaPrimerParcial (int nota) 
        {
            this.notaPrimerParcial = nota;
                    
        }


        public void SetNotaSegundoParcial(int nota)
        {
            this.notaPrimerParcial = nota;

        }
        ///El método privado CalcularPromedio retornará el promedio de las dos notas.
        private double CalcularPromedio() 
        {
            double promedio = ((double)notaPrimerParcial + notaSeguntoParcial)/2;
            return promedio;        
        
        }
        ///El método CalcularNotaFinal deberá retornar la nota del final con un número
        //aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo
        //parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor - 1.
        public double CalcularNotaFinal() 
        {
            double resultado = -1;

            if( notaPrimerParcial >= 4 && notaSeguntoParcial >= 4) 
            {
                double notaFinal = random.Next(6, 10);
                resultado = notaFinal;
            
            }
            return resultado;

        }
        public string Mostrar()
        {


        }

        public string EstudianteToString() 
        {
            stringBuilder texto = new stringBuilder();

            texto.Append ($")
        
        
        }

    }
}
