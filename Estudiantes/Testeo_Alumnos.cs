using Libreria_Alumno;

namespace Alumno
{


    internal class Testeo_Alumnos
    {
        static void Main(string[] args)
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

            //Alumno alumno = new Alumno("PEREZ", "JUAN", "254"); //valor ingresado
            //Materia matematicas = new Materia("Matematicas", 3);

            //Evaluacion ev1 = new Evaluacion(new Alumno("2015", "Carlos", "Rodriguez"));


            //Console.WriteLine($"Alumno: {ev1.Alumno}");
            //Console.WriteLine("Esta cursando: ");


            Random rand = new Random();


            List<Alumno> alumno = new List<Alumno>()
            { //creacion de la instancia de estudiantes
                new Alumno( "Gonzalez","Teresa",1025),
                new Alumno( "Gomez","Teresa",1025),
                new Alumno( "Rodriguez","Teresa",1025),
                new Alumno( "Lopez","Teresa",1025),
                new Alumno( "Mendez","Teresa",1025),
            };

            //foreach (Alumno a in alumno)
            //{
            //    a.SetNotaPrimerParcial(rand)
            //    a.SetNotaSegundoParcial(rand)


            //}





            Console.WriteLine("Mostrar La lista completa");

            //foreach (Alumno item in listaDeAlumno)
            //{
            //    Console.WriteLine(item.AlumnoToString());
            //}

        }
    }




}
