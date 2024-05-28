using System.Security.Cryptography.X509Certificates;

namespace BibliotecaEstudiante
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


        //atributos
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSeguntoParcial;
        private static Random random;


        // constructor de instancia
        public Estudiante(string apellido, string legajo, string nombre) 
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
                                   
        }

        
        static Estudiante() //random
        {
            Estudiante.random = new random();
        
        }

        //metodos
        public void SetNotaPrimerParcial (int nota) 
        {
            this.notaPrimerParcial = nota;
                    
        }


        public void SetNotaSegundoParcial(int nota)
        {
            this.notaPrimerParcial = nota;

        }

        private double CalcularPromedio() 
        {
            double promedio = ((double)notaPrimerParcial + notaSeguntoParcial)/2;
            return promedio;        
        
        }

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
